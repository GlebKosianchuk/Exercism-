public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` typ
    public static string SubstringAfter(this string str, string delimiter) => 
        str[(str.IndexOf(delimiter) + delimiter.Length)..];

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstDelimiter, string secondDelimiter) => 
        str[(str.IndexOf(firstDelimiter) + firstDelimiter.Length)..str.IndexOf(secondDelimiter)];

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log) => log.SubstringAfter(": ");
    
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string log) => log.SubstringBetween("[", "]");
}