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
    public class HowManyPlayers
    {
        private Game _game;

        [SetUp]
        public void Before_Each()
        {
            _game = new Game();
        }

        [Test]
        public void Given_Known_Number_Of_Players_Returns_Expected_Number_Of_Players()
        {
            _game.add("Coral");
            _game.add("Jeff");
            _game.add("Seb");

            var result = _game.howManyPlayers();
            result
                .Should()
                .Be(3);
        }

        [Test]
        public void Given_No_Players_Have_Been_Added_Should_Return_No_Players()
        {
            var result = _game.howManyPlayers();
            result
                .Should()
                .Be(0);
        }
    }
}
