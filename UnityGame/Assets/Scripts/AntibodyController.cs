using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AntibodyController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    float vertical, horizontal;
    Rigidbody2D myRigidbody;
    RectTransform myRectTransform;

    float minX;
    float maxX;
    float minY;
    float maxY;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myRectTransform = GetComponent<RectTransform>();
        minX = -(Screen.width / 2 - 500);
        maxX = (Screen.width / 2 - 500);
        minY = -(Screen.height / 2 - 300);
        maxY = (Screen.height / 2 - 300);
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        // Calculate the new velocity based on user input and moveSpeed
        Vector2 newVelocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
        myRigidbody.velocity = newVelocity;

        // Get the current position of the GameObject
        Vector2 currentPosition = myRigidbody.transform.position;
        float currentX = currentPosition.x;
        float currentY = currentPosition.y;
        //Debug.Log("CurrentX: " + currentX + " CurrentY: " + currentY);

        // Access posX and posY from the RectTransform component
        float posX = myRectTransform.anchoredPosition.x;
        float posY = myRectTransform.anchoredPosition.y;
        //Debug.Log("posX: " + posX + " posY: " + posY);


        if (posX < minX || posX > maxX || posY < minY || posY > maxY)
        {
            
            posX = Mathf.Clamp(posX, minX, maxX);
            posY = Mathf.Clamp(posY, minY, maxY);
            myRectTransform.anchoredPosition = new Vector2(posX, posY);

            Debug.Log("Out of bounds, new pos: " + posX + ", " + posY);
        }


    }
}
