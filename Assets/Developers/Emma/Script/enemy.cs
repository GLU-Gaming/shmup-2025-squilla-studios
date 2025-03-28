using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bulletPrefab;
    private float shootTimer = 2f;
    [SerializeField] private float shootCooldown = 0.5f;
    public Vector3 pos;

    void Start()
    {
        
    }
     
    
    void Update()
    {
        //transform.position = new Vector3(pos.x + Mathf.Sin(Time.time) * 2, pos.y , pos.z);
         
        transform.LookAt(target.transform);
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime;
        }

        if (shootTimer <= 0)
        {
            Shoot();
            shootTimer = shootCooldown;
        }
    }
    private void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }
}
