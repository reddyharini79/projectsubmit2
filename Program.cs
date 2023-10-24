

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Studentdatafile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OpenAndReadTXTFile();
            Console.Read();
        }
        private static void OpenAndReadTXTFile()
        {
            //checking file is in the given location or NOT if not it goes to else block
            bool ans = File.Exists(@"C:\Users\Raj\Desktop\pp2\file1.txt");

            if (ans == true)
            {
                //this try catch block used to if there any exceptions catch block executed otherwise try executed
                try
                {
                    //this command used to open the file and read it ... 
                    FileStream fs = new
                   FileStream(@"C:\Users\HP\OneDrive\Desktop\.net\MyPracticeProject\textfile.txt", FileMode.Open, FileAccess.Read);
                    StreamReader reading = null;
                    //this try catch block used to if there any exceptions catch block executed otherwise try executed
                    try
                    {
                        //Retrieve the data from the file to readme string ..and print it in console..
                        reading = new StreamReader(fs);
                        string readme = reading.ReadToEnd();
                        Console.WriteLine(readme);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        fs.Close();
                        fs.Dispose();
                        reading.Close();
                        reading.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File does'nt exist on the given location");
            }
        }
    }
}