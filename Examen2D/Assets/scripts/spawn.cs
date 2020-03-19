using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public float minTime;
    public float maxTime;

    IEnumerator SpawnCoroutine(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);
        Instantiate(itemPrefabs[Random.Range(0, itemPrefabs.Length)], transform.position, Quaternion.identity);

        // Para que vuelva a ejecutar la corrutina con un tiempo aleatorio
        StartCoroutine(SpawnCoroutine(Random.Range(minTime, maxTime)));
    }
    void Start()
    {
        StartCoroutine(SpawnCoroutine(0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
