using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject BubblePrefab;
    public Transform bubbleSpawnPoint;
    public float bulletSpeed = 1000f;
    public float timer = 0f;
    public float cooldown = 0.00001f;
    public float timesShot = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && timer <= 0)
        {
            Debug.Log("space key was pressed");
            Shoot();
            timesShot++;

        }
        timer -= Time.deltaTime;
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(BubblePrefab, bubbleSpawnPoint.position, bubbleSpawnPoint.rotation);
        timer = cooldown;

    }
}
