using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ECS.Component;
namespace ECS.System
{
    public class MoveSystem : ISystem
    {
        public string name => EcsConst.SystemConst.MOVE;

        private bool _enabled = false;
        private List<IComponent> _tranformList;

        public bool enabled 
         {
        get{ return _enabled; }
         }

        public void Update()
        {

        }


    }
}
