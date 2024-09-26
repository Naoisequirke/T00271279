using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddExplosionForce(300, transform.position + new Vector3(0,-1,0), 2);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.AddExplosionForce(300, transform.position + new Vector3(1, 0, 0), 2);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.AddExplosionForce(300, transform.position + new Vector3(-1, 0, 0), 2);

        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.AddExplosionForce(300, transform.position + new Vector3(0, -1, -1), 2);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.AddExplosionForce(300, transform.position + new Vector3(0, 0, 1), 2);
    }
}
