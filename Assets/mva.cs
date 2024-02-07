using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mva : MonoBehaviour
{

    private float speed = 400f;
    private float ro_speed = 100f;
    public Rigidbody rb;
    public Transform t;
    float force = 20f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            t.Rotate(0, -ro_speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            t.Rotate(0, ro_speed * Time.deltaTime, 0);
        }

    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = -transform.forward * speed * Time.deltaTime;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            Vector3 dir = transform.forward; // Get the forward direction of the player
            if (Input.GetKey(KeyCode.RightShift))
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
            if (Input.GetKey(KeyCode.RightShift))
            {
                other.GetComponent<Rigidbody>().velocity = dir.normalized * force + dir * 3;
            }
        }
    }
}