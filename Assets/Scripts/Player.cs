using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public UnityEvent shootBullet; 
    public GameObject bulletPrefab;
    private float clampedX;


    // Update is called once per frame
    void Update()
    {   
        clampedX = Mathf.Clamp(transform.position.x, -8, 8);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
        transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space)){
            shootBullet.Invoke();
            // TODO: In the Unity Editor, we need to identify functions to listen to this event. 
            //       When this event is invoked, spawn the bullet and play a laser sound! 
        }
    }

    public void SpawnBullet(){
        // TODO: Instantiate the bullet prefab! 
        // Instantiate(???, ???, Quaternion.identity);
    }




}
