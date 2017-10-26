using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model.Decorator {
    public class ShieldFighterDecorator : BaseFighterDecorator{
        public int ShieldDefends { get; set; }

        public ShieldFighterDecorator (IFighter fighter, int defends) : base (fighter) {
            ShieldDefends=defends;
        }

        public override void Defend (Attack attack) {
            if (ShieldDefends>0) {
                attack.Messages.Add ("Shield protected, attack value = 0");
                attack.Value=0;
                ShieldDefends--;
            }
            Fighter.Defend (attack);
        }
    }
}
