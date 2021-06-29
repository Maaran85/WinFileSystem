using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public abstract class ABSRootFileSystem
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Created On")]
        protected DateTime created
        {
            get;
            set;
        }

        [DisplayName("Modified On")]
        protected DateTime lastUpdated
        {
            get;
            set;
        }

        [DisplayName("Last Accessed")]
        protected DateTime lastAccessed
        {
            get;
            set;
        }

        [DisplayName("File System Name")]
        protected string Name
        {
            get;
            set;
        }

        protected string Path
        {
            get;
            set;
        }

        public ABSRootFileSystem()
        {
            created = DateTime.Now;
            lastUpdated = DateTime.Now;
            lastAccessed = DateTime.Now;
        }

        public abstract void ChangePath();
        public abstract void Create();

        public DateTime getcreationTime()
        {
            return created;
        }

        public DateTime getLastUpdatedTime()
        {
            return lastUpdated;
        }

        public DateTime getLastAccessedTime()
        {
            return lastAccessed;
        }

        public void changeName(String n)
        {
            Name = n;
        }

        public string getName()
        {
            return Name;
        }

        public string getPath()
        {
            return Path;
        }

    }
}
