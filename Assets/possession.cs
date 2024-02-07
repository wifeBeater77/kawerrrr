using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class possession : MonoBehaviour
{
    public Transform ball;
    public Transform ballp;
    private void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform== ball)
        {
            ball.transform.position = ballp.transform.position ;
        }
    }


}
