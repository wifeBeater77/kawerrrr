using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2m : MonoBehaviour
{
    private float speed = 3500f;
    public Rigidbody rb;
    public Transform t;
    private Quaternion r1;
    private Quaternion r2;
    float force = 50f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        r1 = Quaternion.AngleAxis(17f, new Vector3(0, 1, 0));
        r2 = Quaternion.AngleAxis(17f, new Vector3(0, -1, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= r1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= r2;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            Vector3 dir = new Vector3(0, 0, -1);
            if (Input.GetKey(KeyCode.RightShift))
            {
                other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0, -3, 0);
            }

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            Vector3 dir = new Vector3(0, 0, -1);
            if (Input.GetKey(KeyCode.RightShift))
            {
                other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0, -3, 0);
            }

        }
    }
}
