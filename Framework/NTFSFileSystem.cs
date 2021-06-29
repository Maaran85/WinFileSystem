using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class NTFSFileSystem : ABSWinFileSystem
    {

        public void Encryption()
        {
        }

        public void AccessControl()
        {
        }


        public override void CalculateBlock()
        {
            throw new NotImplementedException();
        }

        public override void CreateSector()
        {
            throw new NotImplementedException();
        }

        public override void PartitionDetails()
        {
            throw new NotImplementedException();
        }
    }

}
