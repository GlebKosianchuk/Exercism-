static class LogLine
{
    public static string Message(string logLine) => 
        logLine[(logLine.LastIndexOf(':') + 1)..].Trim();

    public static string LogLevel(string logLine) =>                     
        logLine[1..logLine.IndexOf(']')].Trim().ToLower();

    public static string Reformat(string logLine) => 
        $"{Message(logLine)} ({LogLevel(logLine)})";
}
