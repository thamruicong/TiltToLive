using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    private GameObject player;
    public GameObject powerUpPrefab;
    private Vector2 screenDimensions;
    public float powerUpSpawnRadius = 5.0f;

    public float spawnDelay = 1.0f;
    public float spawnDelayRate = 1.0f;
    public float spawnDelayChange = 0.1f;
    public float spawnLimit = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        // powerUpPrefab = TODO
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

            while (Vector2.Distance(player.transform.position, spawnPosition) <= powerUpSpawnRadius) 
            {
                spawnPosition = new Vector3(Random.Range(screenDimensions.x * -1, screenDimensions.x), Random.Range(screenDimensions.y * -1, screenDimensions.y), 0);
            }

            Instantiate(powerUpPrefab, spawnPosition, Quaternion.identity);
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
