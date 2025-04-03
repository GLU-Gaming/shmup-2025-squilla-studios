using UnityEngine;
using UnityEngine.SceneManagement;

public class Bosshealth : BaseEnemy
{
    public float bosshealth = 100;

    public Spawner mouth;
    public Spawner claw1;
    public Spawner claw2;
    public Spawner leg1;
    public Spawner leg2;

    private void Update()
    {
        if (bosshealth <= 95)
        {
            mouth.enabled = true;
        }
        if (bosshealth <= 90)
        {
            claw1.enabled = true;
        }
        if (bosshealth <= 85)
        {
            claw2.enabled = true;
        }
        if (bosshealth <= 50)
        {
            leg1.enabled = true;
            leg2.enabled = true;
        }

    }

    public override void TakeDamage()
    {
        throw new System.NotImplementedException();
    }

    void OnTriggerEnter(Collider other)
    {
       // Debug.Log("Collision detected with: " + other.gameObject.name);

        if (other.gameObject.tag == "PlayerBullet")
        {
            Debug.Log("Player collision detected");
            bosshealth = bosshealth - 2;
            Debug.Log("remaining: " + bosshealth);

            if (bosshealth <= 0)
            {
                
                gameObject.SetActive(false);
            
            }
        }
    }
}
