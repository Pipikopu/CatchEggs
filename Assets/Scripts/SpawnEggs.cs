using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEggs : MonoBehaviour
{
    public GameObject eggPrefab;
    public GameObject bombPrefab;
    public float spawnTime;
    private float randSpawn;
    public float bombAndEggRatio;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(autoSpawnEggs());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnEgg()
    {
        randSpawn = Random.Range(-1, bombAndEggRatio);
        if (randSpawn >= 0)
        {
            GameObject egg = Instantiate(eggPrefab) as GameObject;
            egg.transform.position = new Vector2(Random.Range(-6, 6), Random.Range(6, 9));
        }
        else
        {
            GameObject bomb = Instantiate(bombPrefab) as GameObject;
            bomb.transform.position = new Vector2(Random.Range(-6, 6), Random.Range(6, 9));
        }

    }

    IEnumerator autoSpawnEggs()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnEgg();
        }
    }
}
