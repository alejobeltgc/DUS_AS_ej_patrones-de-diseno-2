using System;

namespace Ejercicio3.Prototype.Model
{
    public abstract class HeroModel
    {
        public string Name { get; set; }
        public string Skin { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public string Skill { get; set; }

        public HeroModel(string name, string skin)
        {
            Name = name;
            Skin = skin;
        }

        protected HeroModel(HeroModel other)
        {
            Name = other.Name;
            Skin = other.Skin;
            Experience = other.Experience;
            Level = other.Level;
            Skill = other.Skill;
        }

        public abstract int Magic();
        public abstract int Attack();
        public abstract int Defense();

        public abstract HeroModel Clone();
    }
}

