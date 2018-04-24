using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.RPG
{
    public class NPC
    {
        public int MaxLife;
        public int CurrentLife;

        public int Attack()
        {
            return 10;
        }

        public NPC(int MaxLife, int CurrentLife)
        {
            this.MaxLife = MaxLife;
            this.CurrentLife = CurrentLife;
        }

        public NPC(int HealLife)
        {
            this.MaxLife = HealLife;
            this.CurrentLife = HealLife;
        }


        //public int Heal(int HealLife)
        //{
        //    int ile życia leczymy, ale nie mozna uleczyc wiecej niz Maxlife,


        //}
    }
    
}
