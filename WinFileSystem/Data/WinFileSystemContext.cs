using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WinFileSystem.Data
{
    public class WinFileSystemContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WinFileSystemContext() : base("name=WinFileSystemContext")
        {
        }

        public System.Data.Entity.DbSet<Framework.ABSWinFileSystem> ABSWinFileSystems { get; set; }

        public System.Data.Entity.DbSet<Framework.ABSRootFileSystem> ABSRootFileSystems { get; set; }

        public System.Data.Entity.DbSet<Framework.Directory> Directories { get; set; }

        public System.Data.Entity.DbSet<Framework.File> Files { get; set; }
    }
}
