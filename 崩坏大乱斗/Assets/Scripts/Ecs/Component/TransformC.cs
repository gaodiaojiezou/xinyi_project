using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS.Component
{
    public class TransformC :IComponent
    {
        public string name => EcsConst.ComponentsConst.TRANSFORM;
        private bool _enabled = false;

        public bool enabled
        {
            get { return _enabled; }
        }

        /// <summary>
        /// 位置
        /// </summary>
        public Vector3 position { get; set; } = Vector3.zero;
        /// <summary>
        /// 朝向
        /// </summary>
        public Quaternion rotation { get; set; } = Quaternion.identity;
        /// <summary>
        /// 比例
        /// </summary>
        public Vector3 scale { get; set; } = Vector3.zero;

    }
}
