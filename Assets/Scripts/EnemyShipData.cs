using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyShipData", menuName = "GameData/Enemy")]
public class EnemyShipData : ScriptableObject
{
    public float speed = 5;
    public float turnRate = 1;
    public float fireRange = 20;
    public string targetTag;
}
