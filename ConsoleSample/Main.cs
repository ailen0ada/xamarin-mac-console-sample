﻿using System;
using System.CommandLine;
using AppKit;

namespace ConsoleSample
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            var input = string.Empty;

            ArgumentSyntax.Parse(args, syntax =>
            {
                syntax.DefineOption("i|input", ref input, true, "Something interesting to read.");

                syntax.ErrorOnUnexpectedArguments = false;
            });

            if (string.IsNullOrEmpty(input))
            {
                NSApplication.Init();
                NSApplication.Main(args);
            }
            else
            {
                Console.WriteLine($"{input.Length} - {input}");
            }
        }
    }
}
