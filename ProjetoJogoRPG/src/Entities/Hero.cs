using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoJogoRPG.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Hp)
        {
             this.Name = Name;
             this.Level = Level;
             this.HeroType = HeroType;
             this.Hp = Hp;


        }
        public Hero()
        {

        }
        public string  Name;
        public int Level;
        public string HeroType;
        public int Hp;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " " + "Atacou com a sua espada" + " " + " HP:" + this.Hp;
        }
    }
}