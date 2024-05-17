using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player Stat")]

public class PlayerStats : ScriptableObject
{
    //ko cần thiết phải dùng Seralize hay private trong Scriptable Object
    [Header("Config")]
    public int level;

    [Header("Health config")]
    public float Health;
    public float MaxHealth;
}
