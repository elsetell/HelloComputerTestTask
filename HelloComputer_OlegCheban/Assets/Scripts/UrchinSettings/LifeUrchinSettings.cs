using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/LifeUrchinSettings", fileName = "LifeUrchinSettings")]
public class LifeUrchinSettings : ScriptableObject
{
    [Range(0.5f, 2.0f)] public float speedRotate;
    [Range(-0.25f, 0.0f)] public float directLeftLimit;
    [Range(0.0f, 0.25f)] public float directRightLimit;
}