using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception_Library;

namespace Entity_Library
{
    public class Pet
    {
        public int PetID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public string Type { get; set; }

        public Pet(string name, int age, string breed, string type)
        {
            if (age <= 0)
            {
                throw new InvalidPetAgeException("Pet age must be a positive integer.");
            }
            Name = name;
            Age = age;
            Breed = breed;
            Type = type;
        }

        public override string ToString()
        {
            return $"Pet Name: {Name}, Age: {Age}, Breed: {Breed}";
        }
    }

}
