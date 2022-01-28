using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Scorer : MonoBehaviour
{
    public int Hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Hits++;
        Debug.Log($"You've bumped into a thing this many times: {Hits}");
    }
}