using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UglyTrivia;

namespace Trivia.Tests.GameTests
{
    [TestFixture]
    public class CreateRockQuestion
    {
        private Game _game;

        [SetUp]
        public void Before_Each()
        {
            _game = new Game();
        }
        
        [Test]
        public void Given_Valid_Number_Passed_Should_Return_Non_Empty_String()
        {
            var result = _game.createRockQuestion(0);

            result
                .Should()
                .NotBeNullOrWhiteSpace();
        }

        [Test]
        public void Given_Valid_Number_Passed_Should_Return_String_In_Expected_Format()
        {
            var result = _game.createRockQuestion(10);

            result
                .Should()
                .Be("Rock Question 10");
        }
    }
}
