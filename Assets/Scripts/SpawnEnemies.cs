using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public int numOfEnemies;
    public GameObject spawn;
    public GameObject enemy;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnMe());
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private IEnumerator SpawnMe()
    {
        numOfEnemies = 9000;
        for (int i = 0; i < numOfEnemies; i++)
        {
            Instantiate(enemy, spawn.transform.position, spawn.transform.rotation);
            yield return new WaitForSeconds(i);
        }
    }
}