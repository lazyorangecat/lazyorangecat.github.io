using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSchoolBizApp.Services
{
    public class OperationResult
    {
        public bool IsSuccessful { get; set; }
        public Exception Exception { get; set; }
    }
    public static class OperationResultHelper
    {
        public static string WriteLog(this OperationResult value)
        {
            if(value.Exception != null)
            {
                string path = DateTime.Now.ToString("yyyy-mm-dd_hh_mm_ss");
                path = path + ".txt";
                File.WriteAllText(path, value.Exception.ToString());
                return path;
            }
            else
            {
                return "沒有存檔";
            }
        }
    }
}
