﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Online_Commercial_Authomation.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SaleMove> SalesMoves { get; set; }
        public DbSet<PDetail> Details { get; set; }
        public DbSet<Todolist> Todolists { get; set; }
        public DbSet<CargoDetail> CargoDetails { get; set; }
        public DbSet<CargoTracking> CargoTrackings { get; set; }
        public DbSet<Message> Messages { get; set; }


    }
}