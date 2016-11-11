using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceLibrary
{
    public class RaceService : IServiceRace
    {
        Context dbContext = new Context();
        public IEnumerable<Participant> GetAllParticipants()
        {
            return dbContext.Participants;
        }

        public void ChangeParticipant(int id, int vote)
        {
            var part = dbContext.Participants.FirstOrDefault(p=>p.Id==id);
            part.Vote = vote;
            dbContext.SaveChanges();
        }
    }
}
