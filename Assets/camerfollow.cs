using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerfollow : MonoBehaviour
{
    public Transform target;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = new Vector3(target.position.x + offset.x , target.position.y + offset.y , target.position.z + offset.z);
    }
    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
