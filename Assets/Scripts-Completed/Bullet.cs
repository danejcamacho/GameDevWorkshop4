using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    void Start(){
        StartCoroutine("DestroyBulletCoroutine");
    }
    void Update()
    {
        transform.position += Vector3.up * 10.0f * Time.deltaTime;
    }
    
    public IEnumerator DestroyBulletCoroutine(){
        while(true){
            yield return new WaitForSeconds(3.0f);
            Destroy(gameObject);
        }
    }
}
