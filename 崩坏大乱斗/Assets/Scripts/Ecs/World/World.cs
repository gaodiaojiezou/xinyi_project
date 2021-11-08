using System.Collections;
using System.Collections.Generic;
using ECS.Entity;
using ECS.System;
using System;
namespace ECS.World
{
    public class World:IDisposable
    {
        public EntityManager entityManager;
        private Dictionary<string, ISystem> systemDict;

        public World()
        {
            entityManager = new EntityManager();
            systemDict = new Dictionary<string, ISystem>();
        }
         public void AddSystem(ISystem system)
        {
            if(!systemDict.ContainsKey(system.name))
            {
                systemDict.Add(system.name,system);
            }
        }
        public void RemoveSystem(ISystem system)
        {
            if(!systemDict.ContainsKey(system.name))
            {
                systemDict.Remove(system.name);
            }
        }
        public void Update()
        {
            foreach(ISystem each in systemDict.Values)
            {
                each.Update();
            }
        }
        public void Dispose()
        {
            entityManager = null;
            systemDict.Clear();
        }


    }
}
