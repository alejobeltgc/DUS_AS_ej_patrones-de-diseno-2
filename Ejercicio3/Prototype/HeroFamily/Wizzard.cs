using System;
using Ejercicio3.Prototype.Model;

namespace Ejercicio3.Prototype.HeroFamily
{
    public class Wizard : HeroModel
    {
        public Wizard(string name, string skin) : base(name, skin)
        {
        }

        private Wizard(Wizard other) : base(other)
        {
        }

        public override int Attack()
        {
            return 4;
        }

        public override int Defense()
        {
            return 2;
        }

        public override int Magic()
        {
            return 10;
        }

        public override HeroModel Clone()
        {
            return new Wizard(this);
        }
    }
}

