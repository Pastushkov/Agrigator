using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgregatorNS;

namespace AgregatorNS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckResponseClass()
        {
            CheckResponse cr = new CheckResponse() {errorCode = "1331",errorMessage = "Check is null",Status = true };
            Assert.IsNull(cr.errorCode, "CheckResponse.Errorcode  is not independent  checkresponse.status");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestTypeMessage()
        {
            NewAgregator agr = new NewAgregator();
            agr.AgregatorLogger("","");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEmptyTypeMessage()
        {
            NewAgregator agr = new NewAgregator();
            agr.AgregatorLogger("", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNullTypeMessage()
        {
            NewAgregator agr = new NewAgregator();
            agr.AgregatorLogger(null, "");
        }
    }
}
