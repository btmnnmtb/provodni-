using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace xthyjdbr_lkz_7
{
    using System;
    using System.IO;
    namespace FileSystem
    {
        class Program
        {
            public void disc(string[] args)
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    Console.WriteLine($"Название: {drive.Name}");

                    if (drive.IsReady)
                    {
                        Console.WriteLine($"Объем диска: {drive.TotalSize}");
                        Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");

                    }
                }
            }
        }
    }
}



    