using System;
using System.Diagnostics;
using System.Threading;


namespace SystemInformation_Basic_Taskmanager_in_console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "System Information & Basic Taskmanager in console";



            while(true)
            {
                Console.Clear(); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=== SYSTEM INFORMATION ===");
                Console.WriteLine("\n===BASIC TASKMANAGER===");


                using (var proc = Process.GetCurrentProcess())
                {
                    long memBytes = proc.WorkingSet64;
                    Console.WriteLine($"App Memory Usage: {memBytes / 1024 / 1024} MB");
                }

                try
                {
                    var pc = new PerformanceCounter("Memory", "Available MBytes");
                    Console.WriteLine($"Available Memory: {pc.NextValue()} MB");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Available RAM: (PerformanceCounter not supported on this platform)");
                }


                Console.WriteLine("\n===SYSTEM DETAILS===");

                Console.WriteLine($"Machine Name: {Environment.MachineName}");
                Console.WriteLine($"Operating System: {Environment.OSVersion}");
                Console.WriteLine($"Processor Count: {Environment.ProcessorCount}");
                Console.WriteLine($"System Directory: {Environment.SystemDirectory}");
                Console.WriteLine($"User Domain Name: {Environment.UserDomainName}");
                Console.WriteLine($"64-Bit Operating System: {Environment.Is64BitOperatingSystem}");
                Console.WriteLine($"Cpu Procces Count:  {Environment.ProcessorCount}");
                Console.WriteLine($"System Page Size: {Environment.SystemPageSize} bytes");
                Console.WriteLine($"Tick Count: {Environment.TickCount} ms");
                Console.WriteLine($"Logical Drives: {string.Join(", ", Environment.GetLogicalDrives())}");
                Console.WriteLine($"System Uptime: {TimeSpan.FromMilliseconds(Environment.TickCount)}");
                //Console.WriteLine($"Cpu Usage: {Environment.ProcessCpuUsage.Equals}");
                Console.WriteLine($"User Name: {Environment.UserName}");

                //foreach (var process in processes)
                //{
                //    try
                //    {
                //        Console.WriteLine($"{process.Id,-10} {process.ProcessName,-30} {process.WorkingSet64 / (1024 * 1024),-15:N2}");
                //    }
                //    catch
                //    {
                //        // Some system processes might not allow access to their properties
                //    }
                //}
                Console.WriteLine("\nPress Ctrl+C to exit.");
                Console.ResetColor();
                Thread.Sleep(5000);
            }
            
        }
    }
}
