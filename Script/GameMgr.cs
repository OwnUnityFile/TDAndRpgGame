using UnityEngine;
using System.Collections;
//其他类通过该类获取数据
public class GameMgr : MonoBehaviour {
    static GameMgr Inst;
    TableMgr _table;
    public TableMgr GetTableMgr
    {
        get
        {
            if (_table == null)
            {
                _table = new TableMgr();
            }
            return _table;
        }
    }
    public static GameMgr Instance
    {
        get
        {
            if (Inst == null)
            {
                Inst = new GameMgr();
            }
            return Inst;
        }
    }
    void Awake()
    {
        Inst = this;
        
        this.gameObject.AddComponent<HashIDs>();
        this.gameObject.AddComponent<HeroMgr>();
    }
    
	
}
