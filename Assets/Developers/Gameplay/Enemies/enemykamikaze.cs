using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;

public class enemykamikaze : MonoBehaviour
{
    //[SerializeField] private GameObject target;
    //private Rigidbody enemyRb;
    //[SerializeField] private int Speed;
    //[SerializeField] private float sphereRadius;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemy;
    public Vector3 targetPosition;
    public float moveSpeed;
    void Start()
    {
        

    }

   
    void Update()
    {
        /*transform.LookAt(target.transform);
        enemyRb.linearVelocity = transform.forward * Speed;*/
        Vector3 directionToMove = targetPosition - transform.position;
        directionToMove = directionToMove.normalized * Time.deltaTime * moveSpeed;
        float maxDistance = Vector3.Distance(transform.position, targetPosition);
        transform.position = transform.position + Vector3.ClampMagnitude(directionToMove, maxDistance);
    }

    
    
    //when spawned go the the location of where the player was 
   }
