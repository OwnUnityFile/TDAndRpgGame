using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HeroMgr : MonoBehaviour
{
    GameObject Hero;
    List<GameObject> HeroItem = new List<GameObject>();
    void Awake()
    {
        Hero = Resources.Load(GameMgr.Instance.GetTableMgr.HeroItem[0].HeroName) as GameObject;
        HeroItem.Add(Hero);
        Instantiate(HeroItem[0]);
    }


    // Hero = Resources.Load(GameMgr.Instance.GetTable.HeroItem[0].HeroName) as GameObject;



}
