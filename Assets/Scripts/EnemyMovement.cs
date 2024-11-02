using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float sideToSideDist = 2.0f;
    public float sideToSideSpeed = 1.0f;
    private GameObject player;
    public UnityEvent enemyHit;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        gameManager = FindObjectOfType<GameManager>();
        StartCoroutine("DestroyEnemyCoroutine");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        // player moves left to right repeatedly
        transform.position += Vector3.right * Mathf.Sin(Time.time * sideToSideSpeed) * sideToSideDist * Time.deltaTime;
            
    }

    public IEnumerator DestroyEnemyCoroutine(){
        while(true){
            yield return new WaitForSeconds(3.0f);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Bullet"){
            enemyHit.Invoke();
            // TODO: Can you write two lines that destroy the bullet and this ship? 
            // ???;
            // ???;  

            // CHALLENGE: Currently, the enemyHit event is not calling anything when we invoke it.
            //            Can you think up functions that we might call when an enemy gets hit with a bullet? What parts of the game would be affected?
            //            Get creative! You might need to write your own functions. Connect them to this event from the Unity Editor. 
            //            Examples: Increment the score, play an enemy death sound, etc. 
        }
    }


}
