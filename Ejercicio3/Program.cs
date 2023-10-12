
using System;
using Ejercicio3.Prototype.HeroFamily;

public class Program
{
    public static void Main(string[] args)
    {
        
        Warrior warrior = new Warrior("Warrior1", "Armor");
        Warrior clonedWarrior = (Warrior)warrior.Clone();
        clonedWarrior.Name = "ClonedWarrior";


        Wizard wizard = new Wizard("Wizard1", "Robe");
        Wizard clonedWizard = (Wizard)wizard.Clone();
        clonedWizard.Name = "ClonedWizard";


        Archer archer = new Archer("Archer1", "Bow");
        Archer clonedArcher = (Archer)archer.Clone();
        clonedArcher.Name = "ClonedArcher";

        
        Console.WriteLine("Información del Guerrero Original:");
        Console.WriteLine($"Nombre: {warrior.Name}, Skin: {warrior.Skin}");
        Console.WriteLine("Información del Guerrero Clonado:");
        Console.WriteLine($"Nombre: {clonedWarrior.Name}, Skin: {clonedWarrior.Skin}");

        Console.WriteLine("\nInformación del Mago Original:");
        Console.WriteLine($"Nombre: {wizard.Name}, Skin: {wizard.Skin}");
        Console.WriteLine("Información del Mago Clonado:");
        Console.WriteLine($"Nombre: {clonedWizard.Name}, Skin: {clonedWizard.Skin}");

        Console.WriteLine("\nInformación del Arquero Original:");
        Console.WriteLine($"Nombre: {archer.Name}, Skin: {archer.Skin}");
        Console.WriteLine("Información del Arquero Clonado:");
        Console.WriteLine($"Nombre: {clonedArcher.Name}, Skin: {clonedArcher.Skin}");
    }
}
