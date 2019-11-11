using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AprioritDenysKarpenko
{
    public class FolderContext : DbContext, IFolderDbContext
    {
        public FolderContext()
            : base("DbConnection")
        {
            Database.SetInitializer(new FolderContextInitializer());
        }

        public DbSet<Folder> Folders { get; set; }
    }
}