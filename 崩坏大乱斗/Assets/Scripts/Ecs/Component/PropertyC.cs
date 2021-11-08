using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS.Component
{
    public class PropertyC : IComponent
    {
        public string name => EcsConst.ComponentsConst.TRANSFORM;
        private bool _enabled = false;

        public bool enabled
        {
            get { return _enabled; }
        }
        /// <summary>
        /// 生命值
        /// </summary>
        public int hp { get; set; }
        /// <summary>
        /// 魔法值
        /// </summary>
        public int mp { get; set; }
        /// <summary>
        /// 攻击力
        /// </summary>
        public int attack { get; set; }
        /// <summary>
        /// 攻击间隔
        /// </summary>
        public float attackTime { get; set; }
        /// <summary>
        /// 移动速度
        /// </summary>
        public int speed { get; set; }
    }
}
