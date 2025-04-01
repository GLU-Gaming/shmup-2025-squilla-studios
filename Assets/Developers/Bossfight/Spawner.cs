// Bullet Spawner


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    enum SpawnerType { Straight, Spin, Circle, Star }


    [Header("Bullet Attributes")]
    public GameObject bullet;
    public float bulletLife = 1f;
    public float speed = 1f;


    [Header("Spawner Attributes")]
    [SerializeField] private SpawnerType spawnerType;
    [SerializeField] private float firingRate = 1f;


    private GameObject spawnedBullet;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        switch (spawnerType)
        {
            case SpawnerType.Straight:

                break;
            case SpawnerType.Spin:
                SpinSpawnPoint();
                break;
            case SpawnerType.Circle:

                break;
            case SpawnerType.Star:

                break;
        }



        //if (spawnerType == SpawnerType.Straight)
        //{

        //}
        //else if (spawnerType == SpawnerType.Spin)
        //{
        //    timer += Time.deltaTime;
        //    transform.localEulerAngles = new Vector3(0f, 0f, transform.localEulerAngles.z + 1f);
        //    if (timer >= firingRate)
        //    {
        //        Fire();
        //        timer = 0;
        //    }
        //}
    }

    private void SpinSpawnPoint()
    {
        timer += Time.deltaTime;
        transform.localEulerAngles = new Vector3(0f, 0f, transform.localEulerAngles.z + 1f);
        if (timer >= firingRate)
        {
            Fire();
            timer = 0;
        }
    }

    private void Fire()
    {
        if (bullet)
        {
            spawnedBullet = Instantiate(bullet, transform.position, transform.rotation);
            spawnedBullet.transform.rotation *= Quaternion.Euler(-90, 0, 0);
            spawnedBullet.GetComponent<BulletHELL>().speed = speed;
            spawnedBullet.GetComponent<BulletHELL>().bulletLife = bulletLife;
        }
    }
}
//enum met verschillende patronen