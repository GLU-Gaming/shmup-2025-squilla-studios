using Unity.VisualScripting;
using UnityEngine;

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
        if (transform.position.x > 8.3f)
        {
            transform.position = new Vector3(8.3f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -8.3f)
        {
            transform.position = new Vector3(-8.3f, transform.position.y, transform.position.z);
        }
        if (transform.position.z > 7.6f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 7.6f); 
        }
        else if (transform.position.z < -4.31f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -4.31f);
        }
    }
 //7,6 -4,31
 
   
        
}
