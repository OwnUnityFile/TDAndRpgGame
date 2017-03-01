using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//用来存放数据资源(待补充)
public class TableMgr : MonoBehaviour
{

    
    /// <summary>
    /// 加载信息方式待定
    /// </summary>
    /// <returns></returns>
    void Awake()
    {
        
        
    }
    public List<Table.Icon> IconItem = new List<Table.Icon>();          //存放物品信息
    public List<Table.Hero> HeroItem = new List<Table.Hero>();          //存放英雄信息
    public List<Table.Critter> CritterItem = new List<Table.Critter>(); //存放中立生物信息
    public List<Table.Npc> NpcItem = new List<Table.Npc>();             //存放Npc信息   
    public List<Table.Mission> MissionItem = new List<Table.Mission>(); //存放任务信息
    public List<Table.Enemy> EnemyItem = new List<Table.Enemy>();       //存放敌人信息   
    

    /// <summary>
    /// 获取所有的物品信息(特定人物加载特定物品)
    /// </summary>
    public void GetIconItem()
    {

    }
    /// <summary>
    /// 获取所有的人物信息
    /// </summary>
    public void GetHeroItem()
    {

    }
    /// <summary>
    /// 获取中立生物信息
    /// </summary>
    public void GetCritterItem()
    {

    }
    //获取Npc信息
    public void GetNpcItem()
    {

    }
    //获取任务信息
    public void GetMissionItem()
    {

    }
    //获取敌人信息
    public void GetEnemyItem()
    {

    }
}
