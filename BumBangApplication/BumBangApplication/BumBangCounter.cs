namespace BumBangApplication
{
    public class BumBangCounter : IBumBangCounter
    {
        private int _counter;

        public BumBangCounter(int initValue = 1)
        {
            _counter = initValue;
        }

        public int Counter => _counter;

        public bool IsDevidableByThree => _counter % 3 == 0;

        public bool IsDevidableBySeven => _counter % 7 == 0;

        public void AddUp()
        {
            _counter++;
        }
    }
}
