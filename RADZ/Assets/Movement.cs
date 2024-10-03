using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
            print("Could not find Animator Component");
        else
            print("Animator Componet found");
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunning", false);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
            animator.SetBool("isRunning", true);
        }
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -50 * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime;
            animator.SetBool("isRunning", true);
        }

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 50 * Time.deltaTime);

        if (Input.GetKey(KeyCode.E)) {
            transform.position += transform.forward * Time.deltaTime;
            transform.position += transform.right * Time.deltaTime;
            animator.SetBool("isRunning", true);
        }

        if (Input.GetKey(KeyCode.Q)) {
            transform.position += transform.forward * Time.deltaTime;
            transform.position -= transform.right * Time.deltaTime;
            animator.SetBool("isRunning", true);
        }
        
       
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("ouch");
        Football_Script myFootball = collision.gameObject.GetComponent<Football_Script>();
        if (myFootball != null)
        {
            myFootball.Kick();
        }
    }
}
