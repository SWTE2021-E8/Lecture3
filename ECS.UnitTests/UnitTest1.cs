using NUnit.Framework;
using ECS.Redesign;

namespace ECS.UnitTests
{
    public class Tests
    {
        IHeater heater;
        [SetUp]
        public void Setup()
        {
            heater = new Heater();

        }

        //Heater Tests
        [Test]
        public void TurnOnHeater_returnIsHeatingTrue()
        {
            heater.TurnOn();
            Assert.IsTrue(heater.IsHeating());
        }

        [Test]
        public void TurnOffHeater_returnIsHeatingFalse()
        {
            heater.TurnOff();
            Assert.IsFalse(heater.IsHeating());
        }
    }
}