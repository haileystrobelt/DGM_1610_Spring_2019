﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    [SerializeField] private float value;

    public float Value
    {
        get { return value; }
        set {this.value -= value}
    }
}
