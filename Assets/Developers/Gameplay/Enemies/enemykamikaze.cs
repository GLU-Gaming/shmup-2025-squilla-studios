using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;

public class enemykamikaze : BaseEnemy
{
    
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemy;
    public Vector3 targetPosition;
    public float moveSpeed;
    void Start()
    {
        player = FindFirstObjectByType<PlayerController>().gameObject;
        targetPosition = player.transform.position;

    }

   
    void Update()
    {
        transform.LookAt(player.transform);
        
        Vector3 directionToMove = targetPosition - transform.position;
        directionToMove = directionToMove.normalized * Time.deltaTime * moveSpeed;
        
        float maxDistance = Vector3.Distance(transform.position, targetPosition);
        transform.position = transform.position + Vector3.ClampMagnitude(directionToMove, maxDistance);

        if(maxDistance < 0.2f)
        {
            Destroy(gameObject);

            //Gebruik Physics.OverlapSphere() om een array van colliders te krijgen
            //gebruik een for loop op die array om damage te doen aan de speler

        }
    }

    
    
    //when spawned go the the location of where the player was 
   }
