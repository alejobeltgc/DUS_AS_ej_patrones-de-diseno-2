using System;
using Ejercicio3.Prototype.Model;

namespace Ejercicio3.Prototype.HeroFamily
{
    public class Archer : HeroModel
    {
        public Archer(string name, string skin) : base(name, skin)
        {
        }

        private Archer(Archer other) : base(other)
        {
        }

        public override int Attack()
        {
            return 7;
        }

        public override int Defense()
        {
            return 6;
        }

        public override int Magic()
        {
            return 3;
        }

        public override HeroModel Clone()
        {
            return new Archer(this);
        }
    }
}
