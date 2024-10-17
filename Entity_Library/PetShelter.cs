using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Library
{
    public class PetShelter
    {
        private List<Pet> availablePets = new List<Pet>();

        public void AddPet(Pet pet)
        {
            availablePets.Add(pet);
            Console.WriteLine($"{pet.Name} has been added to the shelter.");
        }

        public void RemovePet(Pet pet)
        {
            if (availablePets.Contains(pet))
            {
                availablePets.Remove(pet);
                Console.WriteLine($"{pet.Name} has been removed from the shelter.");
            }
            else
            {
                Console.WriteLine($"{pet.Name} is not available in the shelter.");
            }
        }

        public void ListAvailablePets()
        {
            if (availablePets.Count == 0)
            {
                throw new NullReferenceException("No available pets in the shelter.");
            }

            foreach (var pet in availablePets)
            {
                Console.WriteLine(pet.ToString());
            }
        }
    }

}
