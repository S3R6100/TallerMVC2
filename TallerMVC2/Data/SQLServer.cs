using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerMVC2.Models;

    public class SQLServer : DbContext
    {
        public SQLServer (DbContextOptions<SQLServer> options)
            : base(options)
        {
        }

        public DbSet<TallerMVC2.Models.Equipo> Equipo { get; set; } = default!;

public DbSet<TallerMVC2.Models.Jugadores> Jugadores { get; set; } = default!;
    }
