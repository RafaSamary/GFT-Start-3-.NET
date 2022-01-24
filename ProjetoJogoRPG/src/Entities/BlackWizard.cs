using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoJogoRPG.src.Entities
{
    public class BlackWizard:Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int Hp)
        {
             this.Name = Name;
             this.Level = Level;
             this.HeroType = HeroType;
             this.Hp = Hp;
        }
        public override string Attack()
        {
            return this.Name + " " +  "Lançou Black Magic" + " " + "HP:" + this.Hp;
        }
         
             }
            
        }
    
