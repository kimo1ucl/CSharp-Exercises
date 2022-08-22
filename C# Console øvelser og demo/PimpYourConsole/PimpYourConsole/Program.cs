using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Spectre.Console;

namespace PimpYourConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            AnsiConsole.Markup("[underline red]Hello[/] World!");

            var calendar = new Calendar(2020, 10);
            AnsiConsole.Write(calendar);

            var font = FigletFont.Load("starwars.flf");

            AnsiConsole.Write(
                new FigletText(font, "Welcome to my pimped Console")
                    .LeftAligned()
                    .Color(Color.Red));

            AnsiConsole.Progress()
    .Start(ctx =>
    {
        // Define tasks
        var task1 = ctx.AddTask("[green]Reticulating splines[/]");
        var task2 = ctx.AddTask("[green]Folding space[/]");

        while (!ctx.IsFinished)
        {
            task1.Increment(1.5);
            task2.Increment(0.5);

            System.Threading.Thread.Sleep(1000);
        }
    });


        }
    }
}
