using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.RPG
{
    class Heroes : NPC
    {
        private List<Weapons> WeaponsList;


        public Heroes(int HealLife) : base(HealLife)
        {
            WeaponsList = new List<Weapons>();
            
            Weapons Axe = new Weapons(12,"Axe");
            WeaponsList.Add(Axe);

            Weapons Sword = new Weapons(8, "Sword");
            WeaponsList.Add(Sword);

            Weapons Fireball = new Weapons(20, "Fireball");
            WeaponsList.Add(Fireball);
        }

        public Heroes(int MaxLife, int CurrentLife) : base(MaxLife, CurrentLife)
        {
        }

        public List<string> Get_Weapon_Name()
        {
            var WeaponsNames = new List<string>();
            foreach (Weapons weaponfromTheList in WeaponsList)
            {
                WeaponsNames.Add(weaponfromTheList.WeaponType);
            }

            return WeaponsNames;

        }
        //public int ReturnWeaponDamage()
        //{
        //    var WeaponsNames = new List<string>();
        //    foreach (Weapons weaponfromTheList in WeaponsList)
        //    {
        //        WeaponsNames.Add(weaponfromTheList.WeaponType);
        //    }

        //    return Damage;
        //}


    }
}
