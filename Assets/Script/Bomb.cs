using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
    public GameObject bombEffect;

    void OnCollisionEnter(Collision col)
    {
        Instantiate(bombEffect, 
            transform.position, Quaternion.identity);
        if (col.gameObject.tag.Contains("Spider"))
        {
            col.gameObject.GetComponent<Animator>().SetTrigger("Damage");
            col.gameObject.GetComponent<SpiderState>().HanbleDamage();
        }

        Destroy(gameObject);
    }
    
}
