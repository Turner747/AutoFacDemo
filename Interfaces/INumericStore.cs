namespace AutoFacDemo.Interfaces
{
    public interface INumericStore
    {
        void Add(int number);
        void Remove(int number);
        bool Contains(int number);
    }
}
