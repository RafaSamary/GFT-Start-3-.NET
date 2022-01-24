using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoJogoRPG.src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType, int Hp)
        {
             this.Name = Name;
             this.Level = Level;
             this.HeroType = HeroType;
             this.Hp = Hp;
        }
         public override string Attack()
        {
            return this.Name + " " +  "Ataque Ninja" + " " + "HP:" + this.Hp;
        }
    }
}