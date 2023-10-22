using UnityEngine;

public class MovePrefab : MonoBehaviour
{
    public float xSpeed = 2.0f; // Speed in the x-axis
    public float ySpeed = 2.0f; // Speed in the y-axis
    public float distance = 10.0f; // Distance to move

    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private bool moving = true; //change to false and use the StartMoving () method to start moving

    void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + new Vector3(distance, 0, 0); // Assuming movement in the x-axis
    }

    void Update()
    {
        if (moving)
        {
            // Calculate the step to move based on speed and Time.deltaTime
            float step = xSpeed * Time.deltaTime;

            // Move the prefab towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

            // Check if the prefab has reached the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
            {
                moving = false;
            }
        }
    }

    // Call this method to start moving the prefab
    public void StartMoving()
    {
        moving = true;
    }
}
