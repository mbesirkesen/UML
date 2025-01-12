using System;
using System.Collections.Generic;

namespace PetManagementSystem
{
    public class Pet : Identifiable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Owner Owner { get; set; }
        public Animal Type { get; set; }
        public PetInformation PetInfo { get; set; }

        public void Feed()
        {
            Console.WriteLine($"{Name} has been fed.");
        }

        public bool IsHerbivore()
        {
            return !Type.Carnivore;
        }
    }

    public class Owner : Experienced
    {
        public string Name { get; set; }
    }

    public class Animal
    {
        public string Type { get; set; }
        public string Breed { get; set; }
        public bool Carnivore { get; set; }
    }

    public class PetInformation
    {
        public List<string> Traits { get; set; }
        public List<Vaccine> Vaccines { get; set; }

        public PetInformation()
        {
            Traits = new List<string>();
            Vaccines = new List<Vaccine>();
        }
    }

    public class Vaccine
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public interface Identifiable
    {
        Guid Id { get; set; }
    }

    public interface Experienced
    {
        string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Owner owner = new Owner { Name = "Alice" };
            Animal animal = new Animal { Type = "Dog", Breed = "Labrador", Carnivore = true };
            PetInformation petInfo = new PetInformation();
            petInfo.Traits.Add("Friendly");
            petInfo.Vaccines.Add(new Vaccine { Name = "Rabies", Type = "Core" });

            Pet pet = new Pet
            {
                Id = Guid.NewGuid(),
                Name = "Buddy",
                Age = 3,
                Owner = owner,
                Type = animal,
                PetInfo = petInfo
            };

            pet.Feed();
            Console.WriteLine($"Is {pet.Name} a herbivore? {pet.IsHerbivore()}");
        }
    }
}
