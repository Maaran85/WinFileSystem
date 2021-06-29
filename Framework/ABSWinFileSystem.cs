using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public abstract class ABSWinFileSystem
    {
        public int Id { get; set; }

        public int sector
        { get; set; }

        public int blocks
        { get; set; }

        public int partition
        { get; set; }

        public abstract void CreateSector();

        public abstract void CalculateBlock();

        public abstract void PartitionDetails();

        public void Fragmentation()
        {
            // Fragmentation Logic
        }
    }
}
