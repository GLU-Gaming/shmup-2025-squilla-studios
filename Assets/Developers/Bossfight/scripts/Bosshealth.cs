using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bosshealth : BaseEnemy
{
    public float bosshealth = 100;
    [SerializeField] public GameObject BossDyingParticle; 
    [SerializeField] public GameObject BossDyingParticle1;
    [SerializeField] public GameObject BossDyingParticle2;
    [SerializeField] public GameObject Bossexplodes;
    public Spawner mouth;
    public Spawner claw1;
    public Spawner claw2;
    public Spawner leg1;
    public Spawner leg2;
    private EnemyhealthUI UI;
    private void Start()
    {
        UI = FindFirstObjectByType<EnemyhealthUI>();
    }

   

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
            UI.spritechange1();
        }
        if (bosshealth <= 25)
        {
            UI.spritechange2();
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
            
            if (bosshealth <= 75)
            {
                Instantiate(BossDyingParticle, transform.position, transform.rotation);
            }
            if (bosshealth <= 50)
            {
                Instantiate(BossDyingParticle1, transform.position, transform.rotation);
            }
            if (bosshealth <= 25)
            {
                Instantiate(BossDyingParticle2, transform.position, transform.rotation);
            }

            if (bosshealth <= 0)
            {
                SceneManager.LoadScene("EndScene");
                gameObject.SetActive(false);
            
            }
        }
    }
}
