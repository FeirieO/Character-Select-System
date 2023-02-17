using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Player")]
public class Character : ScriptableObject
{
    public string Name;

    public float Speed;

    public int Age;

    public string Stamina;

    public enum Level {Novice, Master , GrandMaster, Legendary }

    public Level level;

    public GameObject Player;
}
