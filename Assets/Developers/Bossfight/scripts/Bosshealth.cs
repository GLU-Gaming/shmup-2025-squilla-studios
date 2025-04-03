using UnityEngine;
using UnityEngine.SceneManagement;

public class Bosshealth : BaseEnemy
{
    public float bosshealth = 100;

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
            bosshealth--;
            Debug.Log("remaining: " + bosshealth);

            if (bosshealth <= 0)
            {
                
                gameObject.SetActive(false);
            
            }
        }
    }
}
