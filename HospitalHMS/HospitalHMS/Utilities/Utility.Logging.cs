

namespace HospitalHMS.Utilities;

public static partial class Utility
{
    private const string LogFileName = "HMS File.txt";

 
    static partial void LogAction(string message)
    {
        try
        {
            // check if the log file exists, if not create it
            if (!File.Exists(LogFileName))
                File.Create(LogFileName).Close();
            }

            // format the log entry with timestamp
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            File.AppendAllText(LogFileName, logEntry + Environment.NewLine);
        }
        catch (Exception ex)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error : {ex.Message}");
            Console.ResetColor();
        }
    }

   
    public static void ViewLogs()
    {
        Title("history");
        if (File.Exists(LogFileName))
        {
            try
            {
                // قراءة وعرض جميع سطور السجل
                string[] lines = File.ReadAllLines(LogFileName);
                if (lines.Length > 0)
                {
                    foreach (var line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("No Recourds");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error in: {ex.Message}");
                Console.ResetColor();
            }
        }
        else
        {
            Console.WriteLine("No file History");
        }
        PrintSeparator('=');
    }
}