using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utility
{
    class Log
    {

        public void ErrorMsg(string message)
        {
            try
            {
                using (StreamWriter WriteToFile = new StreamWriter(@"C:\Users\Rai\Desktop\ErrorLog.txt", append: true))
                {
                    WriteToFile.WriteLine($"{DateTime.Now}, Error Message: {message}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Logging system did not work.");
            }
            



        }

    }
}
