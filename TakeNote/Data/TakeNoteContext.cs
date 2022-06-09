using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TakeNote.Models;

namespace TakeNote.Data
{
    public class TakeNoteContext : DbContext
    {
        public TakeNoteContext (DbContextOptions<TakeNoteContext> options)
            : base(options)
        {
        }

        public DbSet<TakeNote.Models.Note>? Note { get; set; }
    }
}
