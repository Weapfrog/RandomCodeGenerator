using RandomWordGenerator.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWordGenerator.Core
{
    class DatabaseEntity : DbContext
    {
        public DbSet<Word> Words { get; set; }
    }
}
