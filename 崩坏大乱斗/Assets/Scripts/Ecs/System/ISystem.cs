namespace ECS.System
{
    public interface ISystem
    {
        string name
        {
            get;
        }
        bool enabled
        {
            get;
        }

        void Update();

    }
}
