namespace KeyboardSharp
{
    public interface IKeyFilter
    {
        bool IsAllowed(string keyValue) => true;
    }
}