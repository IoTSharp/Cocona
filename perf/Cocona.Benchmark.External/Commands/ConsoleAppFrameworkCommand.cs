using ConsoleAppFramework;

namespace Cocona.Benchmark.External.Commands;
//https://github.com/Cysharp/ConsoleAppFramework/blob/1fc5a9a4a558f0415175df414570c5ce8844b843/sandbox/CliFrameworkBenchmark/Commands/ConsoleAppFrameworkCommand.cs#L4
//public class ConsoleAppFrameworkCommand : ConsoleAppBase
//{
//    public void Execute(
//        [global::ConsoleAppFramework.Option("s")]
//        string? str,
//        [global::ConsoleAppFramework.Option("i")]
//        int intOption,
//        [global::ConsoleAppFramework.Option("b")]
//        bool boolOption)
//    {
//    }
//}

public class ConsoleAppFrameworkCommand
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="str">-s</param>
    /// <param name="intOption">-i</param>
    /// <param name="boolOption">-b</param>
    public static void Execute(string? str, int intOption, bool boolOption)
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="str">-s</param>
    /// <param name="intOption">-i</param>
    /// <param name="boolOption">-b</param>
    public static Task ExecuteWithCancellationToken(string? str, int intOption, bool boolOption, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
