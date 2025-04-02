using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;

public class enemykamikaze : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private Rigidbody enemyRb;
    [SerializeField] private int bulletSpeed;
    [SerializeField] private float sphereRadius;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        
    }

   
    void Update()
    {
        //if (Physics.CheckSphere(transform.position, sphereRadius) && gameObject.CompareTag("Player"))
        //{
        //    Debug.Log("AAAAAAAAAAAA *explosion*");
        //}
        transform.LookAt(target.transform);
        enemyRb.linearVelocity = transform.forward * bulletSpeed;
    }

    void checkIfInSphere()
    {
        if (Physics.CheckSphere(transform.position, sphereRadius) && gameObject.CompareTag("Player"))
        {
            Debug.Log("AAAAAAAAAAAA *explosion*");
        }
    }
    

    //make enemy look at player then follow player
    //stop if in radius have a countdown before exploding 
}
