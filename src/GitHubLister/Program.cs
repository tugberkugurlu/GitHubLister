using Microsoft.Framework.Runtime.Common.CommandLine;
using System.Threading.Tasks;
using System;

namespace GitHubLister
{
    public class Program
    {
        public Task<int> Main(string[] args)
        {
            var app = new CommandLineApplication(throwOnUnexpectedArg: true);
            var optionList = app.Option("--list", "List repositories", CommandOptionType.NoValue);
            var userNameOption = app.Option("--username <USERNAME>", "Username of the GitHub user",CommandOptionType.SingleValue);
            app.HelpOption("-?|-h|--help");
            app.Execute(args);
            
            Console.WriteLine(optionList.HasValue());
            Console.WriteLine(userNameOption.Value());
            
            return Task.FromResult(0);
        }
    }
}