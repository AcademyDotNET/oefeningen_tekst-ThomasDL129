using System;

namespace Shell_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo.FileName = "ipconfig";
            process.StartInfo.Arguments = "/all";

            //process.StartInfo.FileName = "arp";
            //process.StartInfo.Arguments = "-a";

            //process.StartInfo.FileName = "getmac";

            //process.StartInfo.FileName = "nslookup";
            //process.StartInfo.Arguments = "google.com";

            //process.StartInfo.FileName = "netstat";


            //process.StartInfo.FileName = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            //process.StartInfo.Arguments = "ap.be";

            //process.StartInfo.FileName = "notepad";
            //process.StartInfo.Arguments = "mytest.txt";

            //process.StartInfo.FileName = "c:\\Temp\\mydocument.docx";
            //process.StartInfo.Arguments = "";

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start(); //start process

            // Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd(); //normal output
            Console.WriteLine(output);
            string err = process.StandardError.ReadToEnd(); //error output (if any)
            Console.WriteLine(err);
            //Continue
            Console.WriteLine("Klaar");
        }
    }
}
