using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    float horizontalInput = 0f;
    float verticalInput = 0f;

    float moveSpeed = 5f;

    float xLimit = 8f;
    float yLimit = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
        {
            horizontalInput = -1f;
        }
        else if(Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            horizontalInput = 1f;
        }
        else if(Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed)
        {
            verticalInput = -1f;
        }
        else if(Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed)
        {
            verticalInput = 1f;
        }
        transform.position += Vector3.right * horizontalInput * moveSpeed * Time.deltaTime; 
        transform.position += Vector3.up * verticalInput * moveSpeed * Time.deltaTime; 
        float clampedX = Mathf.Clamp(transform.position.x, -xLimit, xLimit);
        float clampedY = Mathf.Clamp(transform.position.y, -yLimit, yLimit);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        FindFirstObjectByType<GameManager>().GameOver();
    }
}
