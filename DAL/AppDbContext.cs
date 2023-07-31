using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.DAL
{
    public class AppDbContext:DbContext
    {

       // public DbSet<Assistant> Assistants { get; set; }    //TODO
        public DbSet<Lawyers>Lawyers { get; set; }
        //public DbSet<OtherPersonels> OtherPersonels { get; set; } //TODO
        public DbSet<Costumers> Costumers { get; set; } 
        public DbSet<Court>Courts { get; set; }
        public DbSet<CourtHouse>CourtsHouse { get; set; }   
        public DbSet<Judge>Judges { get; set; }
       // public DbSet<Session> Sessions { get; set; } //TODO
       // public DbSet<Records> Records { get; set; } //TODO
       // public DbSet<Witness> Witness { get; set; } //TODO
        public DbSet<Case> Case { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer(_connectionString);
            Initilazior.Build();
            optionsBuilder.UseSqlServer(Initilazior.Configuration.GetConnectionString("SqlCon"));
            
        }

        public override int SaveChanges()
        {         

            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Case>()
                .HasMany(x => x.Costumers)
                .WithMany(x => x.Case)
                .UsingEntity<Dictionary<string, object>>(
                "CaseCostumerRef",
                x => x.HasOne<Costumers>().WithMany().HasForeignKey("Costumer_Id").HasConstraintName("FK__CostumerId"),
                x => x.HasOne<Case>().WithMany().HasForeignKey("Case_Id").HasConstraintName("FK__CaseId"));
           // modelBuilder.Entity<Session>()
           //.HasOne(s => s.Witness)
           //.WithMany(w => w.Sessions)
           //.HasForeignKey("Witness_Id")
           //.OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Witness>().HasMany(x => x.Sessions).WithOne().HasForeignKey("Witness_Id");




            base.OnModelCreating(modelBuilder);
        }


    }
}
