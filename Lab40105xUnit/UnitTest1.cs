using iBuiltZoo_40105.Class;
using iBuiltZoo_40105.Interfaces;
using System;
using Xunit;

namespace Lab40105xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void TigerIsFelines()
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
        public void GrizzleyNorthAmerican()
        {
            Grizzley grizzley = new Grizzley();
            Assert.False(grizzley.ClimbsTrees);
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
        public void KodiakFromTheJungle()
        {
            Kodiak kodiak = new Kodiak();
            Assert.False(kodiak.HasTail);
        }
        [Fact]
        public void LionsIsFelines()
        {
            Lions lions = new Lions();
            Assert.True(lions is Felines);
        }

        [Fact]
        public void LionsIsDomestic()
        {
            Lions lions = new Lions();
            Assert.False(lions.Domestic);
        }
    }
}