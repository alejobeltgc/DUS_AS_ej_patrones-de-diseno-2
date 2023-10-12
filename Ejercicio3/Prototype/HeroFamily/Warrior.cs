using System;
using Ejercicio3.Prototype.Model;

namespace Ejercicio3.Prototype.HeroFamily
{
    public class Warrior : HeroModel
    {
        public Warrior(string name, string skin) : base(name, skin)
        {
        }

        private Warrior(Warrior other) : base(other)
        {
        }

        public override int Attack()
        {
            return 10;
        }

        public override int Defense()
        {
            return 7;
        }

        public override int Magic()
        {
            return 0;
        }

        public override HeroModel Clone()
        {
            return new Warrior(this);
        }
    }
}
