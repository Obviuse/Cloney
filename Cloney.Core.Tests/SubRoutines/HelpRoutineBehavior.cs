﻿using System.Collections.Generic;
using Cloney.Core.Console;
using Cloney.Core.Localization;
using Cloney.Core.SubRoutines;
using NSubstitute;
using NUnit.Framework;

namespace Cloney.Core.Tests.SubRoutines
{
    [TestFixture]
    public class HelpRoutineBehavior
    {
        private ISubRoutine routine;

        private IEnumerable<string> args;
        private IConsole console;
        private ITranslator translator;
        private ICommandLineArgumentParser commandLineArgumentParser;


        [SetUp]
        public void SetUp()
        {
            args = new[] {"foo"};
            console = Substitute.For<IConsole>();
            translator = Substitute.For<ITranslator>();
            translator.Translate("GeneralHelpMessage").Returns(x => x[0]);
            commandLineArgumentParser = Substitute.For<ICommandLineArgumentParser>();
            commandLineArgumentParser.ParseCommandLineArguments(args).Returns(new Dictionary<string, string> { { "help", "true" } });

            routine = new HelpRoutine(console, translator, commandLineArgumentParser);
        }


        [Test]
        public void Run_ShouldParseIEnumerableToDictionary()
        {
            routine.Run(args);

            commandLineArgumentParser.Received().ParseCommandLineArguments(args);
        }

        [Test]
        public void Run_ShouldAbortForNoArguments()
        {
            commandLineArgumentParser.ParseCommandLineArguments(args).Returns(new Dictionary<string, string>());
            var result = routine.Run(args);

            Assert.That(result, Is.False);
            console.DidNotReceive().WriteLine(Arg.Any<string>());
        }

        [Test]
        public void Run_ShouldAbortForMoreThanOneArgument()
        {
            commandLineArgumentParser.ParseCommandLineArguments(args).Returns(new Dictionary<string, string> { { "help", "true" }, { "foo", "bar" } });
            var result = routine.Run(args);

            Assert.That(result, Is.False);
            console.DidNotReceive().WriteLine(Arg.Any<string>());
        }

        [Test]
        public void Run_ShouldAbortForIrrelevantArgument()
        {
            commandLineArgumentParser.ParseCommandLineArguments(args).Returns(new Dictionary<string, string> { { "foo", "bar" } });
            var result = routine.Run(args);

            Assert.That(result, Is.False);
            console.DidNotReceive().WriteLine(Arg.Any<string>());
        }

        [Test]
        public void Run_ShouldProceedForRelevantArgument()
        {
            var result = routine.Run(args);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Run_ShouldDisplayTranslatedErrorMessageForRelevantArgument()
        {
            routine.Run(args);

            translator.Received().Translate("GeneralHelpMessage");
            console.Received().WriteLine("GeneralHelpMessage");
        }
    }
}