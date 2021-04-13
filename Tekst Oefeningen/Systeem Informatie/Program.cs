using System;
using System.IO;

namespace Systeem_Informatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Machine naam: {Environment.MachineName}");
            Console.WriteLine($"Besturingssysteem: {Environment.OSVersion}");
            Console.WriteLine($"64bit systeem: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Process geheugen: {Environment.WorkingSet/1048576.0} MB");

            Console.WriteLine($"\nWelke schijf wil je info over? ");
            DriveInfoShow(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
            Environment.Exit(0);
        }

        public static void DriveInfoShow(int index)
        {
            long cdriveinbytes = DriveInfo.GetDrives()[index-1].AvailableFreeSpace;
            long totalsize = DriveInfo.GetDrives()[index-1].TotalSize;

            Console.WriteLine($"Beschikbare Ruimte drive {index}: {Math.Round(cdriveinbytes / 1073741824.0, 2)} GB");
            Console.WriteLine($"Totale Ruimte drive {index}: {Math.Round(totalsize / 1073741824.0, 2)} GB");
        }
    }
}
