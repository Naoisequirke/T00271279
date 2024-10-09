using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballPhysics : MonoBehaviour
{
    Rigidbody rb;
    internal void throwSnowball(Transform thrower)
    {
        rb = GetComponent<Rigidbody>();
        rb.AddExplosionForce(3000, thrower.position, 3);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
