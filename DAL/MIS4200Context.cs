﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200Team11.Models; // This is needed to access the models
using System.Data.Entity;

namespace MIS4200Team11.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,MIS4200Team11.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<BusinessUnit> BusinessUnit { get; set; }
        public DbSet<CoreValues> CoreValues { get; set; }
        public DbSet<recognition> Recognitions { get; set; }
        public DbSet<UserData> UserData { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}