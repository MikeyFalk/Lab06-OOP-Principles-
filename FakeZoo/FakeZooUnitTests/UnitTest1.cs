using System;
using Xunit;
using FakeZoo;

namespace FakeZooUnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to make sure the Unicorn is inheriting the Sound() method from Animal
        /// </summary>
        [Fact]
        public void Test_Unicorn_Sound()
        {
            Unicorn gus = new Unicorn();
            string result = gus.Sound();

            Assert.Equal("The animal makes a sound", result);

        }

        /// <summary>
        /// Testing that the Unicorn overrides the Mythical method MagicPower()
        /// </summary>
        [Fact]
        public void Test_Unicorn_Magic_Power_Override()
        {
            Unicorn gus = new Unicorn();
            string results = gus.MagicPower();

            Assert.Equal("tricks humans", results);
        }

        /// <summary>
        /// Asserts that Trogdor did indeed burninate the country side
        /// </summary>
        [Fact]
        public void Test_Dragon_Burninates_For_Realz()
        {
            Dragon trogdor = new Dragon();
            string results = trogdor.Burninate();

            Assert.Equal("Trogdor burninates the countryside", results);
        }

        /// <summary>
        /// Assert that Dragons eat alot of treasure by overriding the method from Animal
        /// </summary>
        [Fact]
        public void Test_Dragon_Eats()
        {
            Dragon trogdor = new Dragon();
            string results = trogdor.Eat();

            Assert.Equal("A dragon needs to eat a lot of treasure", results);
        }

        /// <summary>
        /// Assert that Gryphons are not immortal by checking the overridden bool from Mythical
        /// </summary>
        [Fact]
        public void Test_Gryphon_Immortal()
        {
            Gryphon kenJr = new Gryphon();
            bool results = kenJr.Immortal;

            Assert.False(results);
        }

        /// <summary>
        /// Check to make sure the Gryphon has the correct amount of horns, which is 0, overridden from Mythical
        /// </summary>
        [Fact]
        public void Test_Gryphon_Number_Of_Horns()
        {
            Gryphon kenJr = new Gryphon();
            int results = kenJr.Horns;

            Assert.Equal(0, results);
        }

        /// <summary>
        /// Assert that an Iron Maiden song was inspired by an Albatross, overridden from OfThisRealm
        /// </summary>
        [Fact]
        public void Test_Albatross_Do_Something_Normal_Iron_Maiden_Song()
        {
            Albatross abe = new Albatross();
            string results = abe.DoSomethingNormal();

            Assert.Equal("inspire an Iron Maiden song", results);
        }

        /// <summary>
        /// Assert the the wings property from Animal is overridden with true
        /// </summary>
        [Fact]
        public void Test_Albatross_Has_Wings_Bool()
        {
            Albatross abe = new Albatross();
            bool result = abe.Wings;

            Assert.True(result);
        }

        /// <summary>
        /// Assert that wille the wombat can access the Dig() method from the interface it extends
        /// </summary>
        [Fact]
        public void Test_Wombat_Can_Dig()
        {
            Wombat willie = new Wombat();
            string result = willie.DigDown();

            Assert.Equal("Wombats are great at burrowing and even share their burrows with other animals", result);
        }

        /// <summary>
        /// Assert that the wombat can get and override the Sound() method from Animal
        /// </summary>
        [Fact]
        public void Test_Wombat_Sounds()
        {
            Wombat willie = new Wombat();
            string result = willie.Sound();

            Assert.Equal("Wombats purr like cats", result);
        }

        /// <summary>
        /// Assert that HoneyBadger can use the DigDown() method from the interface ICanDig
        /// </summary>
        [Fact]
        public void Test_Honey_Badger_Dig_Down()
        {
            HoneyBadger henry = new HoneyBadger();
            string result = henry.DigDown();

            Assert.Equal("Honey Badger will dig a hole, it doesn't care", result);
        }

        /// <summary>
        /// Assert once again that Honey Bagders don't care, overridden prop from Animal
        /// </summary>
        [Fact]
        public void Test_Honey_Badger_Diet()
        {
            HoneyBadger henry = new HoneyBadger();
            string result = henry.Diet;

            Assert.Equal("Cobra's, they don't care", result);

        }

        /// <summary>
        /// Assert another time that interfaces are working by making the dragon can Soar() via ICanFly
        /// </summary>
        [Fact]
        public void Test_Dragon_Interface_For_Fly_Works()
        {
            Dragon trogdor = new Dragon();
            string result = trogdor.Soar();

            Assert.Equal("Soar through the sky, terrifying villagers", result);
        }

        /// <summary>
        /// Assert Inheritance by checking bool Wings, a non-overridden virtual prop from Animal
        /// </summary>
        [Fact]

        public void Test_Unicorn_Inheritance_Wings()
        {
            Unicorn sparkly = new Unicorn();
            bool results = sparkly.Wings;

            Assert.False(results);
        }

        /// <summary>
        /// Prove that a method has been overridden by comparing it's return to the default value
        /// </summary>
        public void Test_Method_Override_For_Wombat()
        {
            Wombat willie = new Wombat();
            string results = willie.Eat();
          
            Assert.NotEqual("The animal eats", results);
        }

    }

}
//Wombats eat veggimite sandwiches
//The animal eats
