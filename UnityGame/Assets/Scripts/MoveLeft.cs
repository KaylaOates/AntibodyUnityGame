using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5.0f; 
    private Rigidbody2D rb;
    private bool isMoving = true;
    Vector2 lastPosition;
    public GameObject infoBoxPrefab;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        infoBoxPrefab.SetActive(false);
    }

    void Update()
    {
        if(isMoving)
        {
            transform.Rotate(Vector3.forward * 60.0f * Time.deltaTime);
            Vector2 movement = Vector2.left * speed;
            rb.velocity = movement;

            float xPos = rb.transform.position.x;
            float yPos = rb.transform.position.y;
            lastPosition = new Vector2(xPos, yPos);
        } 
        else
        {
            rb.transform.position = lastPosition;
            if (infoBoxPrefab != null)
            {
                infoBoxPrefab.SetActive(true);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Antibody"))
        {
            //Debug.Log("Collided with white blood cell");
            isMoving = false;
        }
    }
}
