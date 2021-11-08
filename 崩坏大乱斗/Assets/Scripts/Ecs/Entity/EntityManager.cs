using System.Collections;
using System.Collections.Generic;
using System;

namespace ECS.Entity
{
    public class EntityManager : IEntityManager
    {
        public Dictionary<int, IEntity> entityDict = new Dictionary<int, IEntity>();
        public event Action<IEntity> EntityCreated;

        public event Action<IEntity> EntityDeleted;
        public int index ;

        public EntityManager()
        {
            index = 0;
        }
        public T CreateEntity<T>() where T : IEntity, new()
        {
            T val = new T();
            AddEntity(val);
            return val;

        }
        public void AddEntity(IEntity entity)
        {
            entity.ID = index;
            entityDict.Add(index, entity);
            EntityCreated?.Invoke(entity);
            index++;
        }
        public bool DeleteEntity(int id)
        {
            if (entityDict.TryGetValue(id, out IEntity entity))
            {
                EntityDeleted?.Invoke(entity);
                entityDict.Remove(id);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Dispose()
        {
            EntityCreated = null;
            EntityDeleted = null;
            entityDict.Clear();
        }
     }
}
    
