using UnityEngine;
using System.Collections;
//其他类通过该类获取数据
public class GameMgr : MonoBehaviour {
    static GameMgr Inst;
    TableMgr _table;
    public static GameMgr Instance
    {
        get
        {
            return Inst;
        }
    }
    void Awake()
    {
        Inst = this;
        _table = new TableMgr();
    }
    public TableMgr GetTable
    {
        get { return _table; }
    }
	
}
