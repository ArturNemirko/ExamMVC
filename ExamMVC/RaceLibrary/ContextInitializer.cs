using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceLibrary
{
    class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            Participant participant1 = new Participant() { Name = "Donald Trump", Vote = 62};
            Participant participant2 = new Participant() { Name = "Hillary Clinton", Vote = 83 };
            context.Participants.Add(participant1);
            context.Participants.Add(participant2);
            context.SaveChanges();
        }
    }
}
