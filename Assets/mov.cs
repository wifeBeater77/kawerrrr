using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public float speed = 5f; // Adjust this value to control the movement speed
    public float timeToChangeDirection = 4f; // Adjust this value to control how long it takes to change direction

    private float timer;
    private bool moveRight = true;

    void Update()
    {
        // Move the object right or left based on the 'moveRight' flag
        if (moveRight)
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Update the timer
        timer += Time.deltaTime;

        // Check if it's time to change direction
        if (timer >= timeToChangeDirection)
        {
            // Change direction and reset the timer
            moveRight = !moveRight;
            timer = 0f;
        }
    }
}
