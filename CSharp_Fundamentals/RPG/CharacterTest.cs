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
            NPC npc1 = new NPC(20,20);
            npc1.Attack();
            int c = npc1.Attack();

            Assert.AreEqual(10, c);
        }

        [Test]
        public void LifeTest()
        {
            var NPC = new NPC(15,20);

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
    }
}
