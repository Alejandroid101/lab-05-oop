using System;
using Xunit;
using Zoop;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestHawk1()
        {
            Hawk hawk = new Hawk();
            hawk.Genomes = 5;
            Assert.Equal(5, hawk.Genomes);
                
        }
        [Fact]
        public void TestHawk2()
        {
            Hawk hawk = new Hawk();
            hawk.Name = "Killer";
            Assert.Equal("Killer", hawk.Name);
        }
        [Fact]
        public void TestDog1()
        {
            Dog dog = new Dog();
            Assert.Equal("I have been in the zoo for 2 years", dog.TimeInZoo());
        }
        [Fact]
        public void TestDog2()
        {
            Dog Hatchiko = new Dog();
            Hatchiko.Pack = "Dogs thrive in packs";
            Assert.Equal("Dogs thrive in packs", Hatchiko.Pack);
        }
        [Fact]
        public void TestChicken1()
        {
            Chicken little = new Chicken();
            Assert.Equal("This bird has wings, but cannot fly", little.BirdDescription());
        }
        [Fact]
        public void TestChicken2()
        {
            Chicken little = new Chicken();
            Assert.Equal("I have been in the zoo for 6 months", little.TimeInZoo());
        }
        [Fact]
        public void TestWolf1()
        {
            Wolf Balto = new Wolf();
            Assert.Equal("Wolves hunt in packs, there is always an alpha dog", Balto.CanineDescription());
        }
        [Fact]
        public void TestWolf2()
        {
            Wolf Balto = new Wolf();
            Balto.Genomes = 15;
            Assert.Equal(15, Balto.Genomes);
        }
        [Fact]
        public void TestOcelot1()
        {
            Ocelot Meow = new Ocelot();
            Assert.Equal("Ocelot is roaring", Meow.Roars);
        }
        [Fact]
        public void TestOcelot2()
        {
            Ocelot MeowTwo = new Ocelot();
            Assert.Equal("This animal has big claws that allow it to climb trees", MeowTwo.Claws());
        }

        //Testing Interfaces
        [Fact]
        public void TestDogInterfaceTrainned()
        {
            Dog Spike = new Dog();
            Assert.Equal("I Am trainned to assist blind people on the streets!", Spike.Trainned());
        }
        [Fact]
        public void TestDogInterfacePetting()
        {
            Dog Dawg = new Dog();
            Assert.Equal("I will let you pet me as long as you are gentle", Dawg.PetMe());
        }
        [Fact]
        public void TestHawkInterface()
        {
            Hawk Birdy = new Hawk();
            Assert.Equal("I Am trainned to hunt pigeons at the airport!", Birdy.Trainned());
        }
        [Fact]
        public void TestChickenInterface()
        {
            Chicken Popeye = new Chicken();
            Assert.Equal("I will let you pet me as long as you Bok BOK!!!", Popeye.PetMe());
        }


    }
}
