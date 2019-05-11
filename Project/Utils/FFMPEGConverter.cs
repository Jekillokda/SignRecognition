using System;
using System.Diagnostics;

namespace Project
{
   public class FFMPEGConverter
   {
        private string sourcePath;
        private int fps;

    public FFMPEGConverter(string spath, int fps)
        {
            this.sourcePath = spath;
            this.fps = fps;
        }

      public bool convertAll()
        {
            bool isOk = true;
            this.convertVidToImages();
            this.convertVidToSubs();
            return isOk;
        }
      public bool convertVidToSubs()
        {
            bool isStarted = false;
            try
            {
                using (Process myProcess = new Process())
                {
                    var dbf_File = System.IO.Path.GetFileName(sourcePath);

                    string destinationPath = System.IO.Directory.GetParent(sourcePath).FullName + @"\convertedFrom" + dbf_File.Substring(0, dbf_File.LastIndexOf("."));

                    if (!System.IO.Directory.Exists(destinationPath))
                    {
                        System.IO.Directory.CreateDirectory(destinationPath);
                    }

                    string args = " -i " + sourcePath + " -an -vn -map 0:s -c:s copy -f rawvideo " + destinationPath + @"\subs.txt";

                    System.Diagnostics.Debug.WriteLine(args);
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = "ffmpeg";
                    myProcess.StartInfo.Arguments = args;
                    myProcess.StartInfo.CreateNoWindow = false;
                    isStarted = myProcess.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isStarted;
        }
      public bool convertVidToImages()
        {
            bool isStarted = false;
            try
            {
                using (Process myProcess = new Process())
                {
                    var dbf_File = System.IO.Path.GetFileName(sourcePath);

                    string destinationPath = System.IO.Directory.GetParent(sourcePath).FullName + @"\convertedFrom" + dbf_File.Substring(0, dbf_File.LastIndexOf("."));

                    if (!System.IO.Directory.Exists(destinationPath))
                    {
                        System.IO.Directory.CreateDirectory(destinationPath);
                    }
                    string args = " -i " + sourcePath + " -qscale:v 5 -r " + fps + " " + destinationPath + @"\image%d.jpg";
                    System.Diagnostics.Debug.WriteLine(args);
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = "ffmpeg";
                    myProcess.StartInfo.Arguments = args;
                    myProcess.StartInfo.CreateNoWindow = false;
                    isStarted = myProcess.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isStarted;
        }

    }
}
