using System;
namespace ECS.Entity
{
    public interface IEntityManager:IDisposable
    {
        event Action<IEntity> EntityCreated;
        event Action<IEntity> EntityDeleted;
        T CreateEntity<T>() where T : IEntity, new();

        void AddEntity(IEntity entity);

        bool DeleteEntity(int entityID);

    }
}
