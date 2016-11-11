using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceLibrary
{
    interface IServiceRace
    {
        IEnumerable<Participant> GetAllParticipants();
        void ChangeParticipant(int id, int vote);
    }
}
