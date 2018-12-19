using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.Tests.Integration
{
    [TestFixture]
    public class GoldBuilder
    {
        
        [Test]
        public void Build_Text_File()
        {
            string currentOut, gold;

            using(var memOut = new MemoryStream())
            using(var writer = new StreamWriter(memOut))
            {
                var oldOut = Console.Out;
                Console.SetOut(writer);

                for(int i = 0; i < 1000; i++)
                {
                    GameRunner.RunGame(new Random(i));
                }

                Console.SetOut(oldOut);

                writer.Flush();
                memOut.Position = 0;

                using(var reader = new StreamReader(memOut, Encoding.UTF8))
                {
                    currentOut = reader.ReadToEnd();
                }
            }

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Trivia.Tests.gold.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                gold = reader.ReadToEnd();
            }

            Assert.True(gold == currentOut);
        }
    }
}
