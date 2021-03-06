﻿using Rentalbase.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Rentalbase.DAL
{
    public class ManagementContext : DbContext
    {
        public ManagementContext() : base("ManagementContext")
        {
        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Lease> Leases { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}