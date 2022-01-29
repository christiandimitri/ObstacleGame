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
        if (collision.gameObject.tag == "Player")
        {
            mainColor = GetComponent<MeshRenderer>().material.color;
            GetComponent<MeshRenderer>().material.color = Color.yellow;
            gameObject.tag = "Hit";
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = mainColor;
        }
    }
}