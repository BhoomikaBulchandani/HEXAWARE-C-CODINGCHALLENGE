using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Library
{
    public class Dog : Pet
    {
        public string DogBreed { get; set; }

        public Dog(string name, int age, string breed, string type, string dogBreed) : base(name, age, breed, type)
        {
            DogBreed = dogBreed;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Dog Breed: {DogBreed}";
        }
    }

}
