using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEnd.Pages.Data
{
    public class ArcturusContext : DbContext
    {
        public ArcturusContext()
        {

        }

        public ArcturusContext(DbContextOptions<ArcturusContext> options) : base(options)
        {
        }

        public virtual DbSet<TheArticle> TheArticle { get; set; }
    }
}
