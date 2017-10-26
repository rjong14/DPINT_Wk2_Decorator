using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model.Decorator {
    public class StrengthenFighterDecorator : BaseFighterDecorator {
        public StrengthenFighterDecorator (IFighter fighter) : base(fighter)
        {
            fighter.DefenseValue+=fighter.DefenseValue/10;
            fighter.AttackValue+=fighter.AttackValue/10;
        }
    }
}
