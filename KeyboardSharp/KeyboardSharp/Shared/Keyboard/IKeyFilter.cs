namespace KeyboardSharp
{
    public interface IKeyFilter
    {
        bool IsKeyEnabled(string keyValue) => true;

        bool IsFingerLabelEnabled(string finger) => false;

        bool IsFingerLabelKeyEnabled(string keyValue) => true;
    }
}