using UnityEngine;

public class enemySquid : BaseEnemy
{

    private GameObject target;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bulletPrefab;
    private float shootTimer = 2f;
    [SerializeField] private float shootCooldown;
    public Vector3 pos;

    void Start()
    {
        shootCooldown = Random.Range(1.0f, 1.7f);
        target = FindFirstObjectByType<PlayerController>().gameObject;
    }


    void Update()
    {
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
