using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model.Decorator {
    public abstract class BaseFighterDecorator : IFighter {
        protected IFighter Fighter;

        public virtual int Lives {
            get => Fighter.Lives;
            set => Fighter.Lives=value;
        }

        public virtual int AttackValue {
            get => Fighter.AttackValue;
            set => Fighter.AttackValue=value;
        }

        public virtual int DefenseValue {
            get => Fighter.DefenseValue;
            set => Fighter.DefenseValue=value;
        }

        protected BaseFighterDecorator (IFighter fighter) => Fighter=fighter;

        public virtual void Defend (Attack attack) => Fighter.Defend (attack);

        public virtual Attack Attack () => Fighter.Attack ();
    }
}
