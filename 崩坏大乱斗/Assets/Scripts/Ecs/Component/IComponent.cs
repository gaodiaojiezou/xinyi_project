using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ECS.Component
{
    public interface IComponent
    {
        string name
        {
            get;
        }
        bool enabled
        {
            get;
        }
    }
}
