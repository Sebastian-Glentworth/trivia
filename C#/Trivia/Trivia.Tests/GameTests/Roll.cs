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
    public class Roll
    {
        private Game _game;

        [SetUp]
        public void Before_Each()
        {
            _game = new Game();
        }

        [Test]
        public void Given_Enough_Players_And_Valid_Number_Does_Not_Throw()
        {
            //Given enough players
            _game.add("Coral");
            _game.add("geoff");

            _game.roll(1);
            Assert.Pass();
        }
    }
}
