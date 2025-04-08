using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    [System.Serializable]
    public class Wave
    {
        public GameObject[] enemyTypes;
        public int enemyCount;
    }

    public Transform[] spawnPoints;
    public Wave[] waves;
    public GameObject bossPrefab;
    public Transform bossSpawnPoint;

    public float enemyMoveSpeed = 1f;
    public float waveDelay = 3f;

    private int currentWave = 0;
    private bool spawning = false;
    private bool checkingForEnemies = false;
    

    void Start()
    {
        StartCoroutine(SpawnWave());

    }

    IEnumerator SpawnWave()
    {
        if (currentWave < waves.Length)
        {
            spawning = true;
            Wave wave = waves[currentWave];

            int spawnCount = Mathf.Min(wave.enemyCount, spawnPoints.Length);

            // Shuffle spawn points
            List<Transform> shuffledSpawns = new List<Transform>(spawnPoints);
            for (int i = 0; i < shuffledSpawns.Count; i++)
            {
                Transform temp = shuffledSpawns[i];
                int randIndex = Random.Range(i, shuffledSpawns.Count);
                shuffledSpawns[i] = shuffledSpawns[randIndex];
                shuffledSpawns[randIndex] = temp;
            }

            for (int i = 0; i < spawnCount; i++)
            {
                Transform spawnLocation = shuffledSpawns[i];
                GameObject enemyPrefab = wave.enemyTypes[Random.Range(0, wave.enemyTypes.Length)];

                GameObject enemy = Instantiate(enemyPrefab, spawnLocation.position, Quaternion.identity);
                enemy.tag = "Enemy";
                enemy.SetActive(true);
                StartCoroutine(MoveIntoFrame(enemy.transform));
            }

            currentWave++;
            spawning = false;
            checkingForEnemies = true;

            Debug.Log("Wave " + currentWave + " spawned.");
        }
        else
        {   
            //World.BossActive = true; 
            GameObject boss = Instantiate(bossPrefab, bossSpawnPoint.position, Quaternion.identity);
            boss.tag = "Enemy";
            boss.SetActive(true);
            StartCoroutine(MoveIntoFrame(boss.transform));
            Debug.Log("Boss spawned!");
             
        }

        yield return null;
    }

    void Update()
    {
        int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (checkingForEnemies && !spawning && enemyCount == 0)
        {
            Debug.Log("Wave cleared. Preparing next wave...");
            checkingForEnemies = false;
            StartCoroutine(StartNextWaveAfterDelay());
        }
        else if (checkingForEnemies)
        {
            Debug.Log("Enemies remaining: " + enemyCount);
        }
    }
     
    IEnumerator StartNextWaveAfterDelay()
    {
        yield return new WaitForSeconds(waveDelay);
        StartCoroutine(SpawnWave());
    }

    IEnumerator MoveIntoFrame(Transform enemy)
    {
        if (enemy == null) yield break;

        Vector3 targetPos = enemy.position + new Vector3(0, 0, -5f);

        while (enemy != null && Vector3.Distance(enemy.position, targetPos) > 0.1f)
        {
            enemy.position = Vector3.MoveTowards(enemy.position, targetPos, enemyMoveSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
