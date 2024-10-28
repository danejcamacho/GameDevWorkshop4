using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float randomX;
    private bool isSpawning = false;
    // Update is called once per frame
    void Update()
    {  
        if(!isSpawning){
            StartCoroutine("SpawnEnemy");
        }
        
    }

    public IEnumerator SpawnEnemy(){
        isSpawning = true;
        yield return new WaitForSeconds(3);
        Debug.Log("Spawning Enemy");
        randomX = Random.Range(-8, 8);
        Instantiate(enemyPrefab, transform.position + new Vector3(randomX,0,0), Quaternion.identity);
        isSpawning = false;
    }
}
