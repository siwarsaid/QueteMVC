using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QueteMVC.Models;

namespace QueteMVC.Data
{
    public class QueteMVCContext : DbContext
    {
        public QueteMVCContext (DbContextOptions<QueteMVCContext> options)
            : base(options)
        {
        }

        public DbSet<QueteMVC.Models.Article> Article { get; set; } = default!;
    }
}
