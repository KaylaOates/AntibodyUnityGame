using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


//=============================== INSTALL INPUT SYSTEM FOR THIS TO WORK ===============================//
public class AntibodyController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    float vertical, horizontal;
    Rigidbody2D myRigidbody;

    float minX = 200;
    float maxX = 2360;
    float minY = 200;
    float maxY = 1240;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Vector2 position = myRigidbody.position;

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
        }

    }
}
