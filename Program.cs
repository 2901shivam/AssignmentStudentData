using System;
using System.IO;

namespace AssignmentStudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\shiva\\OneDrive\\Desktop\\File.txt.txt";

         

            try
            {
                if (File.Exists(filePath))
                {
                    string[] str = File.ReadAllLines(filePath);
                    Console.WriteLine("Rainbow School Student Details");
                    for (int i=0; i < str.Length; i++)
                    {
                        Console.WriteLine(str[i]);
                    }

                }
                else
                {
                    Console.WriteLine("File does not exist");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Occured"+ex.Message);
            }

            finally
            {
                Console.WriteLine("Program ends here");
            }
            Console.ReadKey();
        }
     
    }
}
