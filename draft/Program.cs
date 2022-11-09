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
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\User\Desktop");

                if (!dirInfo.Exists)
                    dirInfo.Create();

                dirInfo.CreateSubdirectory("testFolder");

               // dirInfo = new DirectoryInfo(@"C:\\" /* Или С:\\ для Windows */ );

               if (dirInfo.Exists)
               {
                   Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
               }

                Console.WriteLine("Удалить testFolder? да/нет");
                string del = Console.ReadLine();

                if(del == "да")
                {
                    // DirectoryInfo dirInfo = new DirectoryInfo("/Users/luft/SkillFactory");
                    // string newPath = "/Users/luft/SkillFactoryNew";
                    //
                    // if (dirInfo.Exists && !Directory.Exists(newPath))
                    //     dirInfo.MoveTo(newPath);
                    string newPath = @"C:\$Recycle.Bin";

                    if (dirInfo.Exists && !Directory.Exists(newPath))
                         dirInfo.MoveTo(newPath);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }



    }
}