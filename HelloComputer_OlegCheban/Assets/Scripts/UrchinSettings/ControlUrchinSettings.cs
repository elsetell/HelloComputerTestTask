using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/ControlUrchinSettings", fileName = "ControlUrchinSettings")]
public class ControlUrchinSettings : ScriptableObject
{
    [Range(0.1f, 0.25f)] public float minScale;
    [Range(0.25f, 0.5f)] public float maxScale;
    [Range(2.0f, 10.0f)] public float minForce;
    [Range(10.0f, 20.0f)] public float maxForce;
}
