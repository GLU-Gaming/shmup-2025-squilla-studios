using UnityEngine;

public class BaseProjectile : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float duration = 1.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * speed;
        Destroy(gameObject, duration);
    }
}
