﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Travel_In_GroupDBEntities1 : DbContext
    {
        public Travel_In_GroupDBEntities1()
            : base("name=Travel_In_GroupDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Registeration> Registerations { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Traveling> Travelings { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
