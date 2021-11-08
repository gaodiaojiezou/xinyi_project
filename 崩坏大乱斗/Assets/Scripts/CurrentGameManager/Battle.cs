using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ECS.World;
public class Battle : MonoBehaviour
{
    private World currentWorld;
    /// <summary>
    /// 各种组件的初始化
    /// </summary>
    private void Awake()
    {
        CreateGame();
        
    }
    /// <summary>
    /// 游戏逻辑的遍历及更新
    /// </summary>
    private void Update()
    {
        currentWorld.Update();
    }
    /// <summary>
    /// 创建游戏
    /// </summary>
    public void CreateGame()
    {
       currentWorld = new World();
    }
    /// <summary>
    /// 战斗销毁的资源处理
    /// </summary>
    private void OnDestroy()
    {
        
    }
}
