using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ECS.Component;
namespace ECS.Entity
{
    public class GameEntity : IEntity
    {
        private int _entityID;

        public int  ID
            {
            get
            { return _entityID; }
            set
            { _entityID = value; }
            }
        /// <summary>
        /// 位置组件
        /// </summary>
        public TransformC _transform;
        /// <summary>
        /// 属性组件
        /// </summary>
        public PropertyC _property;

    }
}
