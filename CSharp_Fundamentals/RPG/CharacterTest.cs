using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Fundamentals.RPG
{

    [TestFixture]
    public class CharacterTest
    {
        [Test]
        public void AttackTest()
        {
            NPC npc1 = new NPC(20, 20);
            npc1.Attack();
            int c = npc1.Attack();

            Assert.AreEqual(10, c);
        }

        [Test]
        public void LifeTest()
        {
            var NPC = new NPC(15, 20);

            int res = NPC.MaxLife - NPC.CurrentLife;

            Assert.Multiple(
                () =>
                {
                    Assert.AreEqual(20, NPC.CurrentLife);
                    Assert.AreEqual(15, NPC.MaxLife);
                    Assert.True(res >= 0, "Current life greater than Max life");
                });
        }

        [Test]
        public void LifeTest2()
        {
            var NPC = new NPC(15);
            Assert.Multiple(
                () =>
                {
                    Assert.AreEqual(20, NPC.MaxLife, "Max life incorrect");
                    Assert.AreEqual(15, NPC.CurrentLife, "Current life incorrect");
                });
            //Assert.True(res>=0 );

        }

        [Test]
        public void LifeCheck()
        {
            var NPC = new NPC(20, 25);

            Assert.That(NPC.CurrentLife, Is.EqualTo(20), "Current life can't be greater than max");



        }

        [Test]
        public void TakeDamage()
        {
            NPC npc2 = new NPC(25);
            npc2.TakeDamage(30);


            Assert.AreEqual(0, npc2.CurrentLife, "error");


        }

        [Test]
        public void AliveTest()
        {
            NPC npc3 = new NPC(25, 0);

            Assert.True(npc3.isAlive(), "dead");


        }

        [Test]
        public void HeroesTest()
        {
            Heroes hero = new Heroes(25);

            Assert.That(hero.Attack(), Is.EqualTo(10), "nor equal");


        }

        [Test]
        public void WeaponsTest()
        {
            Heroes hero = new Heroes(25);

            List<string> newWeaponsList = new List<string> {"Axe", "Sword", "Fireball"};

            Assert.AreEqual(newWeaponsList, hero.Get_Weapon_Name());
            
        }

    }
}
