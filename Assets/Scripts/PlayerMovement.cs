using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public UnityEvent shootBullet;
    public GameObject bulletPrefab;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D)){
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            shootBullet.Invoke();
        }
    }

    public void SpawnBullet(){
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }




}
