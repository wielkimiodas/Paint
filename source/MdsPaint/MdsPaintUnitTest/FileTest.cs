using System;
using MdsPaint;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MdsPaintUnitTest
{
    [TestClass]
    public class FileTest
    {
        [TestMethod]
        public void LoadFileTest()
        {
            var res = FileUtils.GetNewFilePath();
        }
    }
}
