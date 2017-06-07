using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using GerBearStudios.Mirror.GUI.Clock;

namespace GerBearStudios.Mirror.GUI.Tests
{
    [TestClass]
    public class ClockTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cm = new ClockModel();
            cm.Update();
            var cvm = new ClockViewModel();
            cvm.Initialize(cm);
            var cmTest = cm.CurrentTime;
            var cvmTime = cvm.CurrentTime;
            Assert.AreEqual("7:50", cvmTime);
        }
    }
}
