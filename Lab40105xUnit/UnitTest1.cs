using iBuiltZoo_40105.Class;
using iBuiltZoo_40105.Interfaces;
using System;
using Xunit;

namespace Lab40105xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void OwlIsABird()
        {
            Tigers tigers = new Tigers();
            Assert.True(tigers is Felines);
        }

        [Fact]
        public void TigersKingOfTheJungle()
        {
            Tigers tigers = new Tigers();
            Assert.True(tigers.KingOfTheJungle());
        }

        [Fact]
        public void TigersIsAnAnimal()
        {
            Tigers tigers = new Tigers();
            Assert.True(tigers is Felines);
        }

        [Fact]
        public void BlackBearPoops()
        {
            Blackbear blackBear = new Blackbear();
            Assert.True(blackBear.Poops());
        }

        [Fact]
        public void GrizzleyFromTheJungle()
        {
            Grizzley grizzley = new Grizzley();
            Assert.True(grizzley.FromTheJungle());
        }

        [Fact]
        public void GrizzleyIsBears()
        {
            Grizzley grizzley = new Grizzley();
            Assert.True(grizzley is Bears);
        }

        [Fact]
        public void KodiakIsBears()
        {
            Kodiak kodiak = new Kodiak();
            Assert.True(kodiak is Bears);
        }

        [Fact]
        public void SockeyeCanSwim()
        {
            Kodiak kodiak = new Kodiak();
            Assert.True(kodiak.FromTheJungle());

        }
    }
}