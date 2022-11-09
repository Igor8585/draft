using System;
using System.IO;


namespace DirectoryManager
{
    class Program
    {
        public static void Main() 
        {

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"D:\foto\");

                if (!dirInfo.Exists)
                    dirInfo.Create();

                dirInfo.CreateSubdirectory("NewFolder");

               // dirInfo = new DirectoryInfo(@"C:\\" /* Или С:\\ для Windows */ );

               if (dirInfo.Exists)
               {
                   Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
               }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }



    }
}