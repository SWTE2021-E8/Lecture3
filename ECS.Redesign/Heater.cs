namespace ECS.Redesign

{
    public class Heater:IHeater
    {
        public bool heating { private set; get; } = false;
        public void TurnOn()
        {
            heating = true;
            System.Console.WriteLine("Heater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
            heating = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }
        public bool IsHeating()
        {
            return heating;
        }
    }
    public interface IHeater
    {
        public bool IsHeating();
        public void TurnOn();
        public void TurnOff();
        public bool RunSelfTest();
    }
}