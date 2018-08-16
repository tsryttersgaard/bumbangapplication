namespace BumBangApplication
{
    public interface IBumBangCounter
    {
        int Counter { get; }
        bool IsDevidableByThree { get; }
        bool IsDevidableBySeven { get; }
        void AddUp();
    }
}
