using System;

namespace ECS.Redesign
{
    interface ITempSensor
    {
        public int GetTemp();
        public bool RunSelfTest();
    }

    internal class TempSensor : ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;

        }

        class FakeTempSensor : ITempSensor
        {
            private int _gen;

            public int GetTemp()
            {
                return (_gen);
            }

            public void SetTemp(int gen)
            {
                _gen = gen;
            }

            public bool RunSelfTest()
            {
                return (true);
            }
        }
    }
}