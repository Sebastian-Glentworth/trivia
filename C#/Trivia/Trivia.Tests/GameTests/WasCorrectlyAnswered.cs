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
    public class WasCorrectlyAnswered
    {
        private Game _game;

        [SetUp]
        public void Before_Each()
        {
            _game = new Game();
            _game.add("Geoff");
            _game.add("Coral");
        }

        /// <summary>
        /// Doesn't test what it's supposed to.
        /// </summary>
        [Test]
        public void Given_A_Player_Answered_Correctly_And_Player_Is_In_Penalty_Box_And_Is_Not_Leaving_Penalty_Box_Should_Return_True()
        {
            var result = _game.wasCorrectlyAnswered();
            result
                .Should()
                .BeTrue();
        }
    }
}
