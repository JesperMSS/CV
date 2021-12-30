using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CV_Siten.Models
{
    public class DB : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }

        public DbSet<Projekt> Projekts { get; set; }
    }
}