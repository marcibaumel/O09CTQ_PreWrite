using NUnit.Framework;
using O09CTQ_PreWrite.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O09CTQ_PreWrite.UTest
{
    [TestFixture]
    public class FileManagerTest
    {
        private FileManager myFileManager = new FileManager();

        [TestCase ("Wrong")]
        [TestCase ("The Hungerer Games")]
        public void ExistingTest_GiveATitleAndLookUpIfItExisting_ReturnFalse(string a)
        {
            myFileManager = new FileManager(a);
            Assert.IsFalse(myFileManager.ExistingItem(a));
        }
      
    }
}
