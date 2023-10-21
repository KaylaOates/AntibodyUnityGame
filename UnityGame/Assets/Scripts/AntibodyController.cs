using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AntibodyController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    float vertical, horizontal;
    Rigidbody2D myRigidbody;

    float minX;
    float maxX;
    float minY;
    float maxY;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        minX = - (Screen.width/2 - 200) ;
        maxX = (Screen.width/2 - 200);
        minY = - (Screen.height/2 - 200);
        maxY = (Screen.height/2 - 200);

        Debug.Log("minX: " + minX);
        Debug.Log("maxX: " + maxX);
        Debug.Log("minY: " + minY);
        Debug.Log("maxY: " + maxY);

    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        
        myRigidbody.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
        
        Vector2 position = myRigidbody.position;
        float clampedX = Mathf.Clamp(position.x, minX, maxX);
        float clampedY = Mathf.Clamp(position.y, minY, maxY);
        if (position.x < minX || position.x > maxX || position.y < minY || position.y > maxY)
        {
            Debug.Log("Out of bounds: " + position.x + ", " + position.y);
            myRigidbody.position = new Vector2(clampedX, clampedY);
        }

        /*Vector2 position = myRigidbody.position;
        float clampedX = Mathf.Clamp(position.x, minX, maxX);
        float clampedY = Mathf.Clamp(position.y, minY, maxY);

        // Check if the position is within the bounds
        if (position.x >= minX && position.x <= maxX && position.y >= minY && position.y <= maxY)
        {
            // Rigidbody is within bounds, allow movement
            myRigidbody.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
        }
        else
        {
            // Rigidbody is out of bounds, clamp its position
            myRigidbody.position = new Vector2(clampedX, clampedY);
            myRigidbody.velocity = Vector2.zero;
        }*/
    }
}
