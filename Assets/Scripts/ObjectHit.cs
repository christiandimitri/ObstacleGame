using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private Color mainColor;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log($"Wall Bump !!!");
        mainColor = GetComponent<MeshRenderer>().material.color;
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    private void OnCollisionExit(Collision other)
    {
        // Debug.Log($"Collision Exit !!!");
        GetComponent<MeshRenderer>().material.color = mainColor;
    }
}