using UnityEngine;
using System.Collections;

public class HashIDs : MonoBehaviour {
    public static int speed;
    public static int Dead;
    public static int Attack;
    void Awake()
    {
        speed = Animator.StringToHash("speed");
        Dead = Animator.StringToHash("Dead");
        Attack = Animator.StringToHash("Attack");
    }
}
