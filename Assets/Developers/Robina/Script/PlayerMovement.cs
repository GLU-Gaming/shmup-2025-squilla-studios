using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables 
    [SerializeField] private float speed = 5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        // Get the input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // Move the player
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
   
   
        
}
