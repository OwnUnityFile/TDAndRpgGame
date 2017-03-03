using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public struct Icon
{

}
public struct HeroMessage
{
    public string HeroName;
}
public struct Critter
{

}
public struct Npc
{

}
public struct Mission
{

}
public struct Enemy
{

}
//用来存放数据资源(待补充)
public class TableMgr 
{
    

    public  List<Icon> IconItem ;          //存放物品信息
    public  List<HeroMessage> HeroItem;          //存放英雄信息
    public  List<Critter> CritterItem ; //存放中立生物信息
    public  List<Npc> NpcItem ;             //存放Npc信息   
    public  List<Mission> MissionItem ; //存放任务信息
    public  List<Enemy> EnemyItem ;       //存放敌人信息   
    public TableMgr()
    {
        HeroItem = new List<HeroMessage>();
        HeroItem = GetHeroItem();
        IconItem = new List<Icon>();
        IconItem = GetIconItem();
        CritterItem = new List<Critter>();
        CritterItem = GetCritterItem();
        NpcItem = new List<Npc>();
        NpcItem = GetNpcItem();
        MissionItem = new List<Mission>();
        MissionItem = GetMissionItem();
        EnemyItem = new List<Enemy>();
        EnemyItem = GetEnemyItem();
    }
        
       
    
    
    

    /// <summary>
    /// 获取所有的物品信息(特定人物加载特定物品)
    /// </summary>
    List<Icon> GetIconItem()
    {
        return IconItem;
    }
    /// <summary>
    /// 获取所有的人物信息
    /// </summary>
     List<HeroMessage> GetHeroItem()
    {
        HeroMessage TempMessage = new HeroMessage();
        TempMessage.HeroName = "longhuang_daiji_1";
        HeroItem.Add(TempMessage);
        return HeroItem;

    }
    /// <summary>
    /// 获取中立生物信息
    /// </summary>
    List<Critter> GetCritterItem()
    {
        return CritterItem;
    }
    //获取Npc信息
    List<Npc> GetNpcItem()
    {
        return NpcItem;
    }
    //获取任务信息
    List<Mission> GetMissionItem()
    {
        return MissionItem;
    }
    //获取敌人信息
    List<Enemy> GetEnemyItem()
    {

        return EnemyItem;
    }
}
