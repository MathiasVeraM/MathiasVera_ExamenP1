using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MathiasVera_ExamenP1.Models;

namespace MathiasVera_ExamenP1.Data
{
    public class MathiasVera_ExamenP1Context : DbContext
    {
        public MathiasVera_ExamenP1Context (DbContextOptions<MathiasVera_ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<MathiasVera_ExamenP1.Models.MathiasVera> MathiasVera { get; set; } = default!;
        public DbSet<MathiasVera_ExamenP1.Models.Celular> Celular { get; set; } = default!;
    }
}
