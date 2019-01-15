using System;
using Xunit;
using DN_Zoo.Classes;
using DN_Zoo.Classes.Animals;

namespace ZooTest
{
    public class TestingAnimals
    {
        [Fact]
        public void CrowCanFly()
        {
            Crow gregor = new Crow();
        
            Assert.True(gregor.CanFly);
        }

        [Fact]
        public void CrowNotARaptor()
        {
            Crow gregor = new Crow();

            Assert.False(gregor.Raptor);
        }

        [Fact]
        public void EagleCanFly()
        {
            Eagle gregor = new Eagle();

            Assert.True(gregor.CanFly);
        }

        [Fact]
        public void EagleIsARaptor()
        {
            Eagle gregor = new Eagle();

            Assert.True(gregor.Raptor);
        }

        [Fact]
        public void EmuCanNotFly()
        {
            Emu gregor = new Emu();

            Assert.False(gregor.CanFly);
        }

        [Fact]
        public void EmuIsNotBlackAndWhite()
        {
            Emu gregor = new Emu();

            Assert.False(gregor.IsBlackAndWhite);
        }

        [Fact]
        public void OstrichCanNotFly()
        {
            Ostrich gregor = new Ostrich();

            Assert.False(gregor.CanFly);
        }

        [Fact]
        public void OstrichIsBlackAndWhite()
        {
            Ostrich gregor = new Ostrich();

            Assert.True(gregor.IsBlackAndWhite);
        }

        [Fact]
        public void DogIsADog()
        {
            Dog gregor = new Dog();

            Assert.Equal("Dog", gregor.SpeciesName);
        }
        [Fact]
        public void DogIsAMammal()
        {
            Dog gregor = new Dog();

            Assert.Equal("Mammal", gregor.ClassType);
        }

        [Fact]
        public void WolfCantBeDomesticated()
        {
            Wolf gregor = new Wolf();

            Assert.False(gregor.CanBeDomesticated);
        }
        [Fact]
        public void WolfDoesntHaveRetractableClaws()
        {
            Wolf gregor = new Wolf();

            Assert.False(gregor.HasRetractableClaws);
        }

        [Fact]
        public void CatIsACat()
        {
            HouseCat gregor = new HouseCat();

            Assert.Equal("HouseCat", gregor.SpeciesName);
        }
        [Fact]
        public void CatIsAMammal()
        {
            HouseCat gregor = new HouseCat();

            Assert.Equal("Mammal", gregor.ClassType);
        }

        [Fact]
        public void TigerCantBeDomesticated()
        {
            Tiger gregor = new Tiger();

            Assert.False(gregor.CanBeDomesticated);
        }

        [Fact]
        public void TigerHasRetractableClaws()
        {
            Tiger gregor = new Tiger();

            Assert.True(gregor.HasRetractableClaws);
        }

        [Fact]
        public void FrogCanJump()
        {
            Frog gregor = new Frog();

            Assert.True(gregor.CanJump);
        }

        [Fact]
        public void FrogCanSwim()
        {
            Frog gregor = new Frog();

            Assert.True(gregor.CanSwim);
        }

        [Fact]
        public void SalamanderIsAReptile()
        {
            Salamander gregor = new Salamander();

            Assert.Equal("Reptile", gregor.ClassType);
        }

        [Fact]
        public void SalamanderIsASalamander()
        {
            Salamander gregor = new Salamander();

            Assert.Equal("Salamander", gregor.SpeciesName);
        }

        [Fact]
        public void SnakeDoesNotHaveLegs()
        {
            Snake gregor = new Snake();

            Assert.False(gregor.HasLegs);
        }

        [Fact]
        public void SnakeCannotSwim()
        {
            Snake gregor = new Snake();

            Assert.False(gregor.CanSwim);
        }

        [Fact]
        public void GeckosHaveLegs()
        {
            Gecko gregor = new Gecko();

            Assert.True(gregor.HasLegs);
        }

        [Fact]
        public void GeckosAreReptiles()
        {
            Gecko gregor = new Gecko();

            Assert.Equal("Reptile", gregor.ClassType);
        }
    }

    public class TestingInterfaces
    {
        [Fact]
        public void TestingIEatInterfaceDefaultFromBaseClass()
        {
            Gecko gregor = new Gecko();

            Food expectedFood = new Food
            {
                Name = "Default Food",
                Type = "Default Type"
            };

            string expectedFoodString = expectedFood.ToString();
            string actualFoodString = gregor.Food.ToString();
            

            Assert.Equal(expectedFoodString, actualFoodString);
        }

        [Fact]
        public void TestingIEatInterfaceDefaultFromCanineClass()
        {
            Dog gregor = new Dog();

            Food expectedFood = new Food
            {
                Name = "Red Meat",
                Type = "Carnivore"
            };

            string expectedFoodString = expectedFood.ToString();
            string actualFoodString = gregor.Food.ToString();


            Assert.Equal(expectedFoodString, actualFoodString);
        }

        [Fact]
        public void TestingIEatInterfaceOverride()
        {

            Food expectedFood = new Food
            {
                Name = "Red Meat",
                Type = "Carnivore"
            };

            Dog gregor = new Dog();

            gregor.Food = expectedFood;

            string expectedFoodString = expectedFood.ToString();
            string actualFoodString = gregor.Food.ToString();


            Assert.Equal(expectedFoodString, actualFoodString);
        }

        [Fact]
        public void TestingIBiteFromCanine()
        {
            
            Wolf gregor = new Wolf();

            Assert.Equal("Bite", gregor.Bite());
        }

        [Fact]
        public void TestingIBiteFromDog()
        {

            Dog gregor = new Dog();

            Assert.Equal("Don't Bite", gregor.Bite());
        }

        [Fact]
        public void TestingBaseClassInheritanceOfImAliveDog()
        {

            Dog gregor = new Dog();

            Assert.Equal("Alive", gregor.Speak());
        }

        [Fact]
        public void TestingBaseClassInheritanceOfImAliveSalamander()
        {

            Salamander gregor = new Salamander();

            Assert.Equal("Alive", gregor.Speak());
        }

        [Fact]
        public void TestingBaseClassInheritanceOfImAliveOstrich()
        {

            Ostrich gregor = new Ostrich();

            Assert.Equal("Alive", gregor.Speak());
        }
    }
}
