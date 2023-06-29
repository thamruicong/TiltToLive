using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private GameObject player;
    public GameObject enemyPrefab;
    private Vector2 screenDimensions;
    public float enemySpawnRadius = 10.0f;

    public float spawnDelay = 1.0f;
    public float spawnDelayRate = 1.0f;
    public float spawnDelayChange = 0.1f;
    public float spawnLimit = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        // enemyPrefab = TODO
        player = GameObject.FindWithTag("Player");
        screenDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(Spawn());
        StartCoroutine(IncreaseSpawnRate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);

            Vector3 spawnPosition = new Vector3(Random.Range(screenDimensions.x * -1, screenDimensions.x), Random.Range(screenDimensions.y * -1, screenDimensions.y), 0);

            while (Vector2.Distance(player.transform.position, spawnPosition) <= enemySpawnRadius) 
            {
                spawnPosition = new Vector3(Random.Range(screenDimensions.x * -1, screenDimensions.x), Random.Range(screenDimensions.y * -1, screenDimensions.y), 0);
            }

            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }

    IEnumerator IncreaseSpawnRate()
    {
        while (spawnDelay > spawnLimit)
        {
            spawnDelay -= spawnDelayChange;

            yield return new WaitForSeconds(spawnDelayRate);
        }

        yield break;
    }
}
