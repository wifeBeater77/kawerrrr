using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class santer : MonoBehaviour
{
    private float force = 12f;
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
            Vector3 dir = transform.forward; 
            
            
            other.GetComponent<Rigidbody>().velocity = dir.normalized * force + dir * 3;
            
        }
    }
}
