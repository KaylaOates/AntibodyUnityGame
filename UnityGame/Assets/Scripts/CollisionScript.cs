using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    //private bool isMoving = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("white_blood_cell"))
        {
            Debug.Log("Collided with white blood cell");
            //isMoving = false;
        }
    }

    /*private void Update()
    {
        if (isMoving)
        {
            // Add your movement code here, such as using the transform.Translate or Rigidbody.AddForce to move the Virus.
        }
    }*/
}
