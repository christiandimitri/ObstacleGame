using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Dropper : MonoBehaviour
    {
        [SerializeField] private float timeToWait = 5f;

        private void Start()
        {
        }

        private void Update()
        {
            if (Time.time > timeToWait)
            {
                Debug.Log("5 seconds have passed");
            }
        }
    }
}