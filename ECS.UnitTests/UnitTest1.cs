using NUnit.Framework;
using ECS.Redesign;
using Microsoft.VisualBasic;
using NUnit.Framework.Constraints;

namespace ECS.UnitTests
{
    public class Tests
    {
        FakeTempSensor tempSensor = new FakeTempSensor();
        fakeHeater heater = new fakeHeater(false);
        private Redesign.ECS control;
        [SetUp]
        public void Setup()
        {
            control = new Redesign.ECS(23, tempSensor, heater);
        }

        //Heater Tests
        [Test]
        public void ESC_overthreshold()
        {
            tempSensor.SetTemp(24);
            control.Regulate();
            Assert.AreEqual(false,heater.heating);
        }

        [Test]
        public void ESC_underthreshold()
        {
            tempSensor.SetTemp(22);
            control.Regulate();
            Assert.AreEqual(true,heater.heating);
        }

        [Test]
        public void ESC_Atthreshold()
        {
            tempSensor.SetTemp(23);
            control.Regulate();
            Assert.AreEqual(false,heater.heating);
        }


        [Test]
        public void ESC_changetreshold()
        {
            control.SetThreshold(25);
            Assert.AreEqual(25, control.GetThreshold());

        }
    }
}