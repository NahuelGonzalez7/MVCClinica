using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OperaWebSite.Models;

namespace OperaWebSite.Data
{
    public class OperaDbContext :DbContext
    {
        public OperaDbContext() : base("KeyDb") { }
        public DbSet<Opera> Operas { get; set; }
    }
}