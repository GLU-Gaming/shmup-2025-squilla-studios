// Bullet


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletHELL : MonoBehaviour
{
    public float bulletLife = 1f;  // Defines how long before the bullet is destroyed
    public float rotation = 0f;
    public float speed = 1f;


    //private Vector2 spawnPoint;
    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
       // spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }


    // Update is called once per frame
    void Update()
    {
        if (timer > bulletLife) Destroy(this.gameObject);
        timer += Time.deltaTime;
        //transform.position = Movement(timer);
        transform.position += transform.forward * speed * Time.deltaTime;
    }


    //private Vector2 Movement(float timer)
    //{
    //    // Moves right according to the bullet's rotation
    //    float x = timer * speed * transform.right.x;
    //    float y = timer * speed * transform.right.y;
    //    return new Vector2(x + spawnPoint.x, y + spawnPoint.y);
    //}

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy the bullet
            Destroy(this.gameObject);
            // Call the function to deal damage to the player
            Debug.Log("Hit the Player");
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            if (player != null)
            {
                player.TakeDamage();
            }
        }



    }
}


