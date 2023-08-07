namespace AutoFacDemo.Interfaces
{
    public interface IOptionsService
    {
        void DisableOption(int v);
        void EnableOption(int v);
        bool IsOptionEnabled(int v);
    }
}
