using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Directory : ABSRootFileSystem
    {
        [DisplayName("Directory ID")]
        [Required]
        public int DirId { get; set; }

        [DisplayName("Directory Name")]
        [Required]
        public string DirectoryName
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }


        public string CurrentLength
        {
            get;
            set;
        }

        public string MaximumLength
        {
            get;
            set;
        }

        [DisplayName("Last Accessed Date")]
        public string lastDateAccessed
        {
            get;
            set;
        }

        [DisplayName("Modified Date")]
        public string LastUpdated
        {
            get;
            set;
        }

        public string OwnerId
        {
            get;
            set;
        }

        public void Search()
        { }

        public void Delete()
        { }

        public void ListDirectory()
        { }

        public void Rename()
        {
        }

        public override void ChangePath()
        {
            throw new NotImplementedException();
        }


        public override void Create()
        {
            throw new NotImplementedException();
        }
    }
}
