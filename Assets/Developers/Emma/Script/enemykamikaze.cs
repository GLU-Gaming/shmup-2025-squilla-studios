using UnityEngine;
using UnityEngine.AI;

public class enemykamikaze : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private Rigidbody bulletRb;
    [SerializeField] private int bulletSpeed;

    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        
    }

   
    void Update()
    {
        transform.LookAt(target.transform);
        bulletRb.linearVelocity = transform.forward * bulletSpeed;
    }

    //make enemy look at player then follow player
    //stop if in radius have a countdown before exploding 
}
