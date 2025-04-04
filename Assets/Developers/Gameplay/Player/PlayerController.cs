using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float speed = 5f;

    [Header("Health")]
    [SerializeField] private int health = 3;
    [SerializeField] private float invincibilityDuration = 3;
    private float invincibilityCountdown = 0;

    [Header("Shooting")]
    [SerializeField] private float shootCountdownDuration = 0.5f;
    private float shootCountdown = 0;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private Transform BulletSpawnPoint;
    private int timesShot = 0;

    private void Update()
    {
        invincibilityCountdown -= Time.deltaTime;
        ShootUpdate();
    }

    private void FixedUpdate()
    {
        MovementUpdate();
    }

    private void OnTriggerEnter(Collider other)
    {
        BaseEnemy enemy = other.GetComponent<BaseEnemy>();
        enemyProjectile projectile = other.GetComponent<enemyProjectile>();

        if (enemy != null)
        {
            TakeDamage();
        }
        else if (projectile != null)
        {
            TakeDamage();
            Destroy(other.gameObject);
        }
    }

    private void MovementUpdate()
    {
        // Get the input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // Move the player
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        // Keep the player in the screen
        if (transform.position.x > 7.32f)
        {
            transform.position = new Vector3(7.32f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -9.9f)
        {
            transform.position = new Vector3(-9.9f, transform.position.y, transform.position.z);
        }
        if (transform.position.z > 5.02f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 5.02f);
        }
        else if (transform.position.z < -2.67f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -2.67f);
        }
    }

    private void ShootUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && shootCountdown <= 0)
        {
            GameObject bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            shootCountdown = shootCountdownDuration;
            timesShot++;

        }
        shootCountdown -= Time.deltaTime;
    }

    public void TakeDamage()
    {
        Debug.Log("Hit");
        if (invincibilityCountdown > 0)
        {
            return;
        }
        health--;
        invincibilityCountdown = invincibilityDuration;
        if (health <= 0)
        {
            Debug.Log("Game Over");
            gameObject.SetActive(false);
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
    //7,6 -4,31


