using UnityEngine;

public class DrivingObject : MonoBehaviour
{
    float driveSpeed = 5f;

    float destroyX = -8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * driveSpeed * Time.deltaTime;
        if(transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
