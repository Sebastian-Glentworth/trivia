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
    public class IsPlayable
    {
        private Game _game;

        [SetUp]
        public void Before_Each()
        {
            _game = new Game();
        }

        [Test]
        public void Given_There_Are_Not_Enough_Players_Should_Return_False()
        {
            _game.add("Not Enough");

            var result = _game.isPlayable();

            result
                .Should()
                .BeFalse();
        }

        [Test]
        public void Given_There_Are_Enough_Players_Should_Return_True()
        {
            _game.add("Coral");
            _game.add("Jeff");

            var result = _game.isPlayable();

            result
                .Should()
                .BeTrue();
        }
    }
}
