using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DataBaseContext : DbContext
    {
        public DbSet<ResourseEntrance> ResourseEntrances { get; set; }
        public DbSet<DocumentEntrance> DocumentEntrances { get; set; }
        public DbSet<UnitMeansure> UnitMeansures { get; set; }
        public DbSet<Resourse> Resourses { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
