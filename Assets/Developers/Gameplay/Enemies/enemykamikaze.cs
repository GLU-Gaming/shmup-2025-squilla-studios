using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UIElements;

public class enemykamikaze : BaseEnemy
{
    public PlayerController controller;
    [SerializeField] private PlayerController player;
    [SerializeField] private GameObject enemy;
    public Vector3 targetPosition;
    public float moveSpeed;
    [SerializeField] private GameObject DeathParticle;

    public Collider[] colls;
    void Start()
    {
        player = FindFirstObjectByType<PlayerController>();
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
            //Gebruik Physics.OverlapSphere() om een array van colliders te krijgen
            //gebruik een for loop op die array om damage te doen aan de speler

            Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1);
            colls = hitColliders;
            for (int i = 0; i < hitColliders.Length; i++)
            {
                Debug.Log("explosion");
                if (hitColliders[i].CompareTag("Player"))
                {
                    player.TakeDamage();
                }
            }
           // Instantiate(DeathParticle, transform.position, transform.rotation);

            Destroy(gameObject);
            
        }
    }

    
    

    
}
