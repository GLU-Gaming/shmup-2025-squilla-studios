using UnityEngine;

public class enemyProjectile : MonoBehaviour
{
    private Rigidbody bulletRb;
    [SerializeField] private int bulletSpeed;
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        bulletRb.linearVelocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 3f);
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
