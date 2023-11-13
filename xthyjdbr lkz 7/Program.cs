using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.IO.Enumeration;

DriveInfo[] drives = DriveInfo.GetDrives();
foreach (DriveInfo drive in drives)
{
    Console.WriteLine($"  Название: {drive.Name}" + $"Объем диска: {drive.TotalSize / 1024 / 1024 / 1024}" + $"  Свободное пространство: {drive.TotalFreeSpace / 1024 / 1024 / 1024}");


}



Menu Show = new Menu();
Show.minstrel = 0;

int pos = Show.Show();

if (pos == 0)
{
    ShowPapk("C:\\");

}
if (pos == 1)
{
    ShowPapka("D:\\");

}
if (pos == 2)
{
    ShowPap("Z:\\");
}
void ShowPapka(string k)
{

    while (true)
    {   
        
        Console.Clear();
        string[] paths = Directory.GetDirectories(k);
        string[] pathss = Directory.GetFiles(k);
        foreach (string path in paths)
        {
            Console.WriteLine("  " + path + "     " + System.IO.File.GetCreationTime(path).ToString());

        }
        foreach (string path in pathss)
        {

            Console.WriteLine("  " + path + "     " + System.IO.File.GetCreationTime(path).ToString());
        }
        Menu Show = new Menu();
        Show.minstrel = 0;
        int pos = Show.Show();
        
        
        
            
        
        if (pos == -90)
            return;
        if (pos == -1)
        {
            Console.Clear() ;
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"  Название: {drive.Name}" + $"Объем диска: {drive.TotalSize / 1024 / 1024 / 1024}" + $"  Свободное пространство: {drive.TotalFreeSpace / 1024 / 1024 / 1024}");


            }
            
            int poss = Show.Show();
            
                




            if ( poss == 0)
            {
                ShowPapk("C:\\");
            }
            else if (poss == 1)
            {
                ShowPapka("D:\\");
            }
            else if (poss == 2)
            {
                ShowPap("Z:\\");
            }

        }
        

                ShowPapka(paths[pos]);  





    }
}

void ShowPapk(string s)
{

    while (true)
    {
        Console.Clear();

        string[] paths = Directory.GetDirectories(s);
        string[] pathss = Directory.GetFiles(s);
        foreach (string path in paths)
        {
            Console.WriteLine("  " + path + "     " + System.IO.File.GetCreationTime(path).ToString());

        }
        foreach (string path in pathss)
        {

            Console.WriteLine("  " + path + "     " + System.IO.File.GetCreationTime(path).ToString());
        }
        Menu Show = new Menu();
        Show.minstrel = 0;
        int pos = Show.Show();

        if (pos == -1)
        {
            Console.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("  " + $"  Название: {drive.Name}" + $"Объем диска: {drive.TotalSize / 1024 / 1024 / 1024}" + $"  Свободное пространство: {drive.TotalFreeSpace / 1024 / 1024 / 1024}");


            }

            int poss = Show.Show();
            string name = "D\\Новая папка(6)\\.txt";
            
            if (poss == 0)
            {
                ShowPapk("C:\\");
            }
            else if (poss == 1)
            {
                ShowPapka("D:\\");
            }
            else if (poss == 2)
            {
                ShowPap("Z:\\");
            }

        }
        if (pos == -90)
            return;

        ShowPapk(paths[pos]);





    }
}

void ShowPap(string j)
{

    while (true)
    {
        Console.Clear();
        string[] paths = Directory.GetDirectories(j);
        string[] pathss = Directory.GetFiles(j);
        foreach (string path in paths)
        {
            Console.WriteLine("  " + path + "     " + System.IO.File.GetCreationTime(path).ToString());

        }
        foreach (string path in pathss)
        {

            Console.WriteLine("  " + path + "     " + System.IO.File.GetCreationTime(path).ToString());
        }
        Menu Show = new Menu();
        Show.minstrel = 0;
        int pos = Show.Show();
        if (pos == -1)
        {
            Console.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("  " + $"  Название: {drive.Name}" + $"Объем диска: {drive.TotalSize / 1024 / 1024 / 1024}" + $"  Свободное пространство: {drive.TotalFreeSpace / 1024 / 1024 / 1024}");


            }

            int poss = Show.Show();

            if (poss == 0)
            {
                ShowPapk("C:\\");
            }
            else if (poss == 1)
            {
                ShowPapka("D:\\");
            }
            else if (poss == 2)
            {
                ShowPap("Z:\\");
            }

        }
        if (pos == -90)
            return;

        ShowPapk(paths[pos]);





    }
}