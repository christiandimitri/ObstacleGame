using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Dropper : MonoBehaviour
    {
        MeshRenderer renderer => GetComponent<MeshRenderer>();
        Rigidbody rigidbody => GetComponent<Rigidbody>();

        [SerializeField] float timeToWait = 5f;

        private void Start()
        {
            rigidbody.useGravity = false;
            renderer.enabled = false;
        }

        private void Update()
        {
            if (Time.time > timeToWait)
            {
                renderer.enabled = true;
                rigidbody.useGravity = true;
            }
        }
    }
}