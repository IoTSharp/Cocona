using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;

namespace Cocona.Benchmark.External.Commands;

public class SystemCommandLineCommand
{
    public static int ExecuteHandler(string s, int i, bool b) => 0;

    public Task<int> ExecuteAsync(string[] args)
    {
        var command = new RootCommand
        { 
            new Option<string>("string",new[] {"--str", "-s"})
            { 
                  
            },
            new Option<int>("int",new[] {"--int", "-i"})
            {
            },
            new Option<bool>("bool",new[] {"--bool", "-b"})
            {
            }
        };
        command.SetAction(parseResult => SystemCommandLineCommand.ExecuteHandler(
                 parseResult.GetValue<string>("string"),
                 parseResult.GetValue<int>("int"),
                 parseResult.GetValue<bool>("bool")));
        return   command.Parse(args).InvokeAsync();
    }
}
