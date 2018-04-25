using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Fundamentals.RPG
{
    [TestFixture()]

    class HeroTests
    {

        private Heroes testHero;

        [SetUp]
        public void SetUP()
        {
            testHero = new Heroes(100);
        }

        [Test]
        public void HeroesTest()
        {
            Assert.That(testHero.Attack(), Is.EqualTo(10), "nor equal");
        }

        [Test]
        public void Hero_Arms_Race()
        {
            var expected_weapons = new List<string> { "Axe", "Sword", "Fireball" };

            Assert.AreEqual(expected_weapons, testHero.Get_Weapon_Name());
        }

        [Test]
        public void Test10()
        {
            var testDamage = testHero.Return_Weapon_Damage("Sword");
            Assert.AreEqual(8, testDamage, "weapon not on the list");
            //testHero.TakeDamage(10);
            //bool alive = testHero.isAlive();
        }

        [Test]
        public void CheckWeaponDmgWithList()
        {
            var getWeapon = testHero.Get_Weapon_Name();
            var testDamage1 = testHero.Return_Weapon_Damage(getWeapon[0]);
            var testDamage2 = testHero.Return_Weapon_Damage(getWeapon[1]);
            var testDamage3 = testHero.Return_Weapon_Damage(getWeapon[2]);

            Assert.AreEqual(12,testDamage1,"error wep1");
            Assert.AreEqual(8, testDamage2, "error wep2");
            Assert.AreEqual(20, testDamage3, "error wep3");
        }
        [Test]
        public void CheckWeaponDmgWithList_2()
        {
            var getWeapon = testHero.Get_Weapon_Name();
            var expected_DmgForWeapons = new List<int> { 12, 8, 25 };

            for (int i = 0; i <= 2; i++)
            {
              var testDamage = testHero.Return_Weapon_Damage(getWeapon[i]);
              Assert.AreEqual(expected_DmgForWeapons[i], testDamage, "error wep {0}",i);

            } 
           
        }




        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("I am cleaning");
        }

    }
}
