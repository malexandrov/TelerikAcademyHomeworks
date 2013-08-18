using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.AnimalHierarchy
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Tomcat tom = new Tomcat("Tom", 13);
            Tomcat pedigree = new Tomcat("Pedigree", 10);
            Tomcat batman = new Tomcat("Batman the Bulgarian cat", 24);
            Kitten kitty = new Kitten("Kittycat", 1);
            Kitten whiskas = new Kitten("Whiskas", 12);
            Kitten mucka = new Kitten("Mucka the trash cat from Kansas", 18);
            Frog kermit = new Frog("Kermit the frog", 15, "male");
            Frog prince = new Frog("The frog prince", 6, "male");
            Frog krastav = new Frog("Pesho the frog", 3, "male");
            Dog spike = new Dog("Spike", 25, "male");
            Dog goofy = new Dog("Goofy", 14, "male");
            Dog courage = new Dog("Courage the cowardly dog", 7, "male");

            tom.ProduceSound();
            kitty.ProduceSound();
            kermit.ProduceSound();
            spike.ProduceSound();

            List<Animal> teamOne = new List<Animal>();
            teamOne.Add(tom);
            teamOne.Add(pedigree);
            teamOne.Add(batman);
            teamOne.Add(kitty);
            teamOne.Add(mucka);
            teamOne.Add(whiskas);
            teamOne.Add(kermit);
            teamOne.Add(krastav);
            teamOne.Add(goofy);
            teamOne.Add(prince);
            teamOne.Add(spike);
            teamOne.Add(courage);
            
            Console.WriteLine();

            // Static method for calculating average age of different kinds of animals
            AverageAge(teamOne);
        }



        private static void AverageAge(List<Animal> animals)
        {
            var animalsByKind =
                (from animal in animals
                 group animal by animal.GetType().Name into newGroup
                 select new
                 {
                     kindOfAnimal = newGroup.Key,
                     averageAge =
                          (from sortedAnimals in newGroup
                           select sortedAnimals.Age).Average()
                 });

            Console.WriteLine("Animal kinds with average age:");
            foreach (var group in animalsByKind)
            {
                Console.WriteLine(group);
            }
        }
    }
}

