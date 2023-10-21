using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject red_blood_cellPrefab;
    [SerializeField]
    private GameObject virus_greenPrefab;

    [SerializeField]
    private float red_blood_cellInterval = 3.5f;
    [SerializeField]
    private float virus_greenInterval = 10f; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(red_blood_cellInterval, red_blood_cellPrefab));
        StartCoroutine(spawnEnemy(virus_greenInterval, virus_greenPrefab));
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
