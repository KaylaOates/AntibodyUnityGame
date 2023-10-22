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
    private GameObject virus_bluePrefab;
    [SerializeField]
    private GameObject virus_yellowPrefab;

    [SerializeField]
    private float red_blood_cellInterval = 3.5f;
    [SerializeField]
    private float virus_greenInterval = 3f;
    [SerializeField]
    private float virus_yellowInterval = 3f;
    [SerializeField]
    private float virus_blueInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(red_blood_cellInterval, red_blood_cellPrefab));
        StartCoroutine(spawnEnemy(virus_greenInterval, virus_greenPrefab));
        StartCoroutine(spawnEnemy(virus_blueInterval, virus_bluePrefab));
        StartCoroutine(spawnEnemy(virus_yellowInterval, virus_yellowPrefab));
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {

        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(10f, Random.Range(-4.5f, 4.5f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
        virus_greenInterval += 4f * Time.deltaTime;
        virus_yellowInterval += 4f * Time.deltaTime;
        virus_blueInterval += 4f * Time.deltaTime;
    }
}
