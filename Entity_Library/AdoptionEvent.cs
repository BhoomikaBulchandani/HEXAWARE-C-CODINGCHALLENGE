using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Library
{
    public class AdoptionEvent
    {
        public List<IAdoptable> Participants { get; private set; } = new List<IAdoptable>();

        public void HostEvent()
        {
            Console.WriteLine("Adoption Event Hosted.");
            foreach (var participant in Participants)
            {
                participant.Adopt();
            }
        }

        public void RegisterParticipant(IAdoptable participant)
        {
            Participants.Add(participant);
            Console.WriteLine($"{participant.GetType().Name} registered for the adoption event.");
        }
    }

}
