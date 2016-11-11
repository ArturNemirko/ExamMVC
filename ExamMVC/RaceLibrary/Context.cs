using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceLibrary
{
    public class Context : DbContext
    {
        static Context()
        {
           System.Data.Entity.Database.SetInitializer(new ContextInitializer());
        }

        public Context() : base("name = ConnectionRaceDB")
        { }

        public DbSet<Participant> Participants { get; set; }

    }
}
