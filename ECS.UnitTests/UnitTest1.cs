using NUnit.Framework;
using ECS.Redesign;
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
        }

        [Test]
        public void TurnOffHeater_returnIsHeatingFalse()
        {
            
        }
    }
}