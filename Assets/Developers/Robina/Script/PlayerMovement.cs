using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Variables 
    [SerializeField] private float speed = 5f;



    void FixedUpdate()
    {
        // Get the input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // Move the player
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        // Keep the player in the screen
        if (transform.position.x > 7.32f)
        {
            transform.position = new Vector3(7.32f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -9.9f)
        {
            transform.position = new Vector3(-9.9f, transform.position.y, transform.position.z);
        }
        if (transform.position.z > 5.02f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 5.02f);
        }
        else if (transform.position.z < -2.67f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -2.67f);
        }
    }
}
    //7,6 -4,31


