using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class File : Directory
    {
        [DisplayName("File ID")]
        [Required]
        public int FileId { get; set; }

        [DisplayName("File Content")]
        public string content
        {
            get;
            set;
        }

        [DisplayName("File Extension")]
        public string filetype
        {
            get;
            set;
        }

        [DisplayName("File Size")]
        public int filesize
        {
            get;
            set;
        }


        public void ReadFile()
        {

        }

    }
}
