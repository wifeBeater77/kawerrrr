using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private float speed = 400f;
    private float ro_speed = 100f;
    public Rigidbody rb;
    public Transform t;
    float force = 20f;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
          t.Rotate(0, -ro_speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            t.Rotate(0, ro_speed * Time.deltaTime, 0);
        }

    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            rb.velocity = -transform.forward * speed * Time.deltaTime;
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            Vector3 dir = transform.forward; // Get the forward direction of the player
            if (Input.GetKey(KeyCode.Space))
            {
                other.GetComponent<Rigidbody>().velocity = dir.normalized * force + dir * 3;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            Vector3 dir = transform.forward; // Get the forward direction of the player
            if (Input.GetKey(KeyCode.Space))
            {
                other.GetComponent<Rigidbody>().velocity = dir.normalized * force + dir * 3;
            }
        }
    }

    


}
