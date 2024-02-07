using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    float force = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wall"))
        {
            this.transform.Translate(0, 3, -4 * force * Time.deltaTime)   ;
        }
    }
}
