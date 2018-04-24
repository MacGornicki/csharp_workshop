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

        public void TakeDamage(int damage)
        {
            if (damage < CurrentLife)
            {
                CurrentLife -= damage; 
            }
            else
            {
                CurrentLife = 0;
            }

        }

        public bool isAlive()
        {
            if (CurrentLife>0)
            {
                return true;
            }
            else 
            {
                return false;
            }

        }

        public NPC(int MaxLife, int  CurrentLife)
        {
            this.MaxLife = MaxLife;
            if (CurrentLife > MaxLife)
            {
                this.CurrentLife = MaxLife;
            }
            else
            {
                this.CurrentLife = CurrentLife;
            }
            
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
