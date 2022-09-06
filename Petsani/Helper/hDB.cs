using Petsani.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Petsani.Helper
{
    public class hDB : DbContext
    {
        public hDB () : base("Server=.;Database=DBCeyda;User Id=sa;Password=Ceyda123;")
        {


        }
        public DbSet<mUsers> Users { get; set; }
        public DbSet<mUserType> UserType { get; set; }
        public DbSet<mCity> City { get; set; }

        public DbSet<mContact> Message { get; set; }

    }
}