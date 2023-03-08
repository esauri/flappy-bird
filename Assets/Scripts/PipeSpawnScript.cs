using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour {
    public GameObject pipePrefab;
    public float heightOffset = 5;
    public float spawnRate = 2;
    private float timer = 0;


    // Start is called before the first frame update
    void Start() {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update() {
        if (spawnRate > timer) {
            timer += Time.deltaTime;
        } else {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float randomY = Random.Range(lowestPoint, highestPoint);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);

        Instantiate(pipePrefab, spawnPosition, transform.rotation);
    }
}
