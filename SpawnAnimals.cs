using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{

    public GameObject[] animal;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
    public float startDelay;
    public float spawnInterval;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimal",startDelay, spawnInterval);
    }

    void spawnAnimal()
    {
        //what do ya think it does numbnuts?
        Vector3 SpawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0,animal.Length);
        Instantiate(animal[animalIndex], SpawnPos, animal[animalIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
