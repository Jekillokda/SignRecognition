using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   public class ffmpegConverter
   {
        string sourcePath;
        int fps;

    public ffmpegConverter(string spath, int fps)
        {
            this.sourcePath = spath;
            this.fps = fps;
        }

      public  bool convert()
        {
            bool isStarted = false;
            try
            {
                using (Process myProcess = new Process())
                {
                    var dbf_File = System.IO.Path.GetFileName(sourcePath);
                    int i = dbf_File.LastIndexOf(".");

                    string name = dbf_File.Substring(0, i);
                    string destinationPath = System.IO.Directory.GetParent(sourcePath).FullName + @"\converted_from_" + name;

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
