using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoJogoRPG.src.Entities
{
    public class Wizard:Hero
    {
        public Wizard(string Name, int Level, string HeroType, int Hp)
        {
             this.Name = Name;
             this.Level = Level;
             this.HeroType = HeroType;
             this.Hp = Hp;
        }
       public override string Attack()
        {
            return this.Name + " " +  "Lançou magia";
        }
           public string Attack(int Combo)
        {
             if( Combo > 6)
             {
               return this.Name + " " +  "Lançou magia High" + " " +  Combo + " " + "HP:" + this.Hp;
             }
             else
             {
                return this.Name + " " +  "Lançou magia Low" + " " +  Combo + " " + "HP:" + this.Hp;
             }
             }
            
        }
      }
    
