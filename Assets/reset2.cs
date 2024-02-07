using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class reset2 : MonoBehaviour
{
    public Transform p;
    public Transform spawn2;
    public Transform player;
    public Transform player2;
    public Transform spawn;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            collision.transform.position = p.transform.position;
            player.transform.position = spawn.transform.position;
            player2.transform.position = spawn2.transform.position;
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
