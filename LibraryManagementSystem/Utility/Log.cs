using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utility
{
    /// <summary>
    /// Writes a log of error messages when an error occurs throughout the application
    /// </summary>
    class Log
    {

        /// <summary>
        /// contains a message for an technical advisor on the system to understand where the error came from.
        /// </summary>
        /// <param name="message">Customisable message when errors occur.</param>
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
