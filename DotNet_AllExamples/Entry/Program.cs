using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var sLnPath = @"C:\home\GitSamllProjects\DotNet_AllExamples\AllExamples.sln";

                List<KeyValuePair<int, string>> li = GetListOfProjectsFromSln(sLnPath);

                li = li.OrderByDescending(x => x.Key).ToList();

                Console.WriteLine("");
                Console.WriteLine("-----------Start-----------");
                foreach (var item in li)
                    Console.WriteLine($"{item.Key} - {Path.GetFileNameWithoutExtension(item.Value)}");

                var key = GetKeyFromUser();
                var path = li.FirstOrDefault(x => x.Key == key).Value;
                RunThroghCommandLine(path);
            }

        }

        private static List<KeyValuePair<int, string>> GetListOfProjectsFromSln(string sLnPath)
        {
            var Content = File.ReadAllText(sLnPath);
            Regex projReg = new Regex(
                "Project\\(\"\\{[\\w-]*\\}\"\\) = \"([\\w _]*.*)\", \"(.*\\.(cs|vcx|vb)proj)\""
                , RegexOptions.Compiled);
            var matches = projReg.Matches(Content).Cast<Match>();
            var Projects = matches.Select(x => x.Groups[2].Value).ToList();

            List<KeyValuePair<int, string>> li = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < Projects.Count; ++i)
            {
                if (Projects[i].Contains("Entry.csproj"))
                    continue;

                if (!Path.IsPathRooted(Projects[i]))
                    li.Add(new KeyValuePair<int, string>(i + 1, Path.Combine(Path.GetDirectoryName(sLnPath), Projects[i])));

            }

            return li;
        }

        private static int GetKeyFromUser()
        {
            Console.WriteLine($"Select a key:");
            var readKey = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"You selected {readKey}");
            var readKeyProcced = Convert.ToInt32(readKey);
            return readKeyProcced;
        }

        private static void RunThroghCommandLine(string path)
        {
            Console.WriteLine($"Running: dotnet run --project {path}");
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.UseShellExecute = true;
            startInfo.FileName = "cmd.exe";
            //startInfo.Verb = "runas";
            startInfo.Arguments = "/k " + $"dotnet run --project {path}";
            //startInfo.Arguments = 
            process.StartInfo = startInfo;
            process.Start();
            if (process != null && !process.HasExited)
                process.WaitForExit();
        }
    }
}
