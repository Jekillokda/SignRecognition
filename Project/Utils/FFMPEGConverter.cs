using Project.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Project
{
   public class FFMPEGConverter
   {
        private readonly string sourcePath;
        private readonly string savePath;
        int timeStepMilliseconds = 5000;
        List<MovementPoint> pointsList = new List<MovementPoint>();

    public FFMPEGConverter(string spath, string svpath)
        {
            sourcePath = spath;
            savePath = svpath;
        }

      public bool ConvertAll( bool rewrite)
        {
            bool isOk = true;
            var nPath = System.IO.Path.GetFileName(sourcePath);
            string destinationFolderPath = savePath + @"\convertedFrom" + nPath.Substring(0, nPath.LastIndexOf("."));
            string subsPath = "";
            if ((File.Exists(destinationFolderPath)) && (rewrite = true))
            {
                Directory.Delete(destinationFolderPath,true);
                Directory.CreateDirectory(destinationFolderPath);
                ConvertVidToImages(destinationFolderPath);
                subsPath = ConvertVidToSubs(destinationFolderPath);
            }

                pointsList = ParseSubtitleFile(subsPath);
                ImageFolder f = new ImageFolder();
                f.Load(destinationFolderPath);
                f.Sort();
                List<PhotoData> dataList = PhCoord_Connect.Connect(f, pointsList, timeStepMilliseconds).ToList();
            for (int i = 0; i < dataList.Count; i++)
            {
                Console.WriteLine(
                    dataList[i].Photo.Number.ToString() + " "+
                    dataList[i].Photo.FileName +" "+
                    dataList[i].MovementPoint.Lon.ToString() + " " +
                    dataList[i].MovementPoint.Lat.ToString() + " " +
                    dataList[i].MovementPoint.Date.ToString() + " " +
                    dataList[i].MovementPoint.Azimuth);
            }
            
            return isOk;
        }
      public string ConvertVidToSubs(string dFolderPath)
        { 
            string destinationPath = dFolderPath + @"\subs.txt";
            try
            {
                using (Process myProcess = new Process())
                {
                    if (File.Exists(destinationPath))
                        File.Delete(destinationPath);

                    string args = " -i " + sourcePath + " -an -vn -map 0:s -c:s copy -f rawvideo " + destinationPath;

                    System.Diagnostics.Debug.WriteLine(args);
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = "ffmpeg";
                    myProcess.StartInfo.Arguments = args;
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    myProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return destinationPath;
        }
      public bool ConvertVidToImages(string dFolderPath)
        {
            bool isStarted = false;
            try
            {
                using (Process myProcess = new Process())
                {
                    //var dbf_File = System.IO.Path.GetFileName(sourcePath);

                    //string destinationPath = savePath + @"\convertedFrom" + dbf_File.Substring(0, dbf_File.LastIndexOf("."));

                    if (!System.IO.Directory.Exists(dFolderPath))
                    {
                        System.IO.Directory.CreateDirectory(dFolderPath);
                    }
                    var fps = $"1000/{timeStepMilliseconds}";
                    string args = " -i " + sourcePath + " -qscale:v 5 -r " + fps + " " + dFolderPath + @"\image%d.jpg";
                    System.Diagnostics.Debug.WriteLine(args);
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = "ffmpeg";
                    myProcess.StartInfo.Arguments = args;
                    myProcess.StartInfo.CreateNoWindow = false;
                    
                    isStarted = myProcess.Start();
                    myProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isStarted;
        }

      private List<MovementPoint> ParseSubtitleFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return null;
            }

            var subtitles = File.ReadAllText(fileName);

            var movementPointRegExp = @"\d{6}\.\d+,A,\d{4}(\.\d*)?,N,\d{5}(\.\d*)?,E,\d*(\.\d*)?,\d*(\.\d*)?,\d{6},,,.{4}";
            var matches = Regex.Matches(subtitles, movementPointRegExp);
            List<MovementPoint> en = new List<MovementPoint>();
            foreach (Match m in matches){
             string g = m.Value;
             MovementPoint mov = ParseMovementPoint(g);
                pointsList.Add(mov);
             en.Add(mov);
            }
            
            return en;
        }

      private MovementPoint ParseMovementPoint(string movementPoint)
        {
            var parts = movementPoint.Split(new char[] { ',' });

            decimal? azimuth = null;
            if (parts[7].Length > 0)
            {
                azimuth = Convert.ToDecimal(parts[7].Replace(',', '.'), CultureInfo.InvariantCulture);
            }

            var dateString = parts[8] + parts[0].Substring(0, parts[0].IndexOf('.'));
            var date = DateTime.ParseExact(dateString, "ddMMyyHHmmss",
                CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal);

            decimal lat = ConvertDegreesAndDecimalMinutesStringToDecimalDegrees(parts[2]);
            decimal lon = ConvertDegreesAndDecimalMinutesStringToDecimalDegrees(parts[4]);

            return new MovementPoint
            {
                Date = date,
                Lat = lat,
                Lon = lon,
                Azimuth = azimuth
            };
        }

      // Input format: DDDMM.MMMM
        // Output: DDD.DDDDD
      private decimal ConvertDegreesAndDecimalMinutesStringToDecimalDegrees(string degreesAndDecimalMinutesString)
        {
            decimal degreesAndDecimalMinutes = Convert.ToDecimal(
                degreesAndDecimalMinutesString.Replace('.', ','),
                new NumberFormatInfo() { NumberDecimalSeparator = "," });

            decimal degrees = Math.Truncate(degreesAndDecimalMinutes / 100);
            decimal minutes = (degreesAndDecimalMinutes / 100 - degrees) * 100;
            decimal decimalDegrees = degrees + minutes / 60;

            return decimalDegrees;
        }

    }
}
