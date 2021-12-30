using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CV_Siten.Models
{
    public class DB : DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Competences> Competences { get; set; }

        public System.Data.Entity.DbSet<CV_Siten.Models.Project> Projects { get; set; }
    }
}