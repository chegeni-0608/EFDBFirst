using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EFDBFirst.Utility
{
     public static class Logger
    {
        static string _logFolderPath = $"{Application.StartupPath}\\Logs";
        static string _filePath = $"{_logFolderPath}\\log-{DateUtility.GetCurrentShamsiDateWithDash()}.text";
        public static void Error(Exception ex)
        {
            if (!Directory.Exists(_logFolderPath))
            {
             Directory.CreateDirectory(_logFolderPath);
            }
            string errorMessage = $"Error=====>Time:{DateTime.Now}====>Message:{ex.Message}\n Exeption:{ex.ToString()}";
            File.AppendAllLines(_filePath, new List<string> { errorMessage });
        }
    }
}
