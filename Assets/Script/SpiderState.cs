using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderState : MonoBehaviour
{
    public int hp = 5;
    public bool isDead = false;
    public float scale = 5;

    void Start()
    {
    }

    public void HanbleDamage()
    {
        scale -= 1f;
        transform.localScale = new Vector3(scale, scale, scale);
    }

    public void DamageByEnemy()
    {
        if (!isDead && hp <= 0)
        {
           isDead = true;
        }
    }
}