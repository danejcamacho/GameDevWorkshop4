using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float randomX;
    private bool isSpawning = false;
    private float seconds; 
    // Update is called once per frame
    void Update()
    {  
        if(!isSpawning){
            // TODO: Call the Coroutine defined below! 
            // StartCoroutine(???);
        }
        
    }

    public IEnumerator SpawnEnemy(){
        // TODO: Fix the commented out lines so this coroutine spawns a ship every 3 seconds! 
        // isSpawning = ???;
        // seconds = ???;
        yield return new WaitForSeconds(seconds);
        Debug.Log("Spawning Enemy");
        randomX = Random.Range(-8, 8);
        // Instantiate(???, ??? + new Vector3(???,0,0), Quaternion.identity);
        // isSpawning = ???;
    }
}
