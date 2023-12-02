using UnityEngine;

public class UpAndDownMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public float amplitude = 1.0f;

    private Vector3 startPos;

    void Start()
    {
        // Save the initial position of the object
        startPos = transform.position;
    }

    void Update()
    {
        // Move the object up and down over time
        float newY = startPos.y + amplitude * Mathf.Sin(speed * Time.time);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
