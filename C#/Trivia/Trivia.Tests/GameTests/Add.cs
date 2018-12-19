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
    public class Add
    {
        private Game _game;

        [SetUp]
        public void Before_Each()
        {
            _game = new Game();
        }

        [Test]
        public void Given_A_Valid_Name_Should_Return_True()
        {
            var result = _game.add("jeff");

            result
                .Should()
                .BeTrue();
        }

        [Test]
        public void Given_Completely_Not_Sensible_Name_Should_Return_True()
        {
            var result = _game.add(null);

            result
                .Should()
                .BeTrue();
        }
    }
}
