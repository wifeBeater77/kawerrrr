using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;



public class reset : MonoBehaviour
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
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            other.transform.position = p.transform.position;
            player.transform.position = spawn.transform.position;
            player2.transform.position = spawn2.transform.position;
            other.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);

        }
    }

}
