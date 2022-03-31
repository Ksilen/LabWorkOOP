using System;
using System.IO;

namespace WindowsFormsBulldozer
{
    public class MyLogger
    {
        String fileNameLog = "log.txt";
        public MyLogger()
        {
            if (File.Exists(fileNameLog))
            {
                File.Delete(fileNameLog);
            }
        }
        public void Info(String str)
        {
            using (StreamWriter fs = new StreamWriter(fileNameLog, true))
            {
                fs.WriteLine(DateTime.Now.ToString() + " |INFO| " + str);
            }
        }
        public void Warning(String str)
        {
            using (StreamWriter fs = new StreamWriter(fileNameLog, true))
            {
                fs.WriteLine(DateTime.Now.ToString() + " |WARNING| " + str);
            }
        }
    }
}

