using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderState : MonoBehaviour {
    public int hp = 5;
    public bool isDead = false;

    void Start()
    {}

    public void DamageByEnemy()
    {
        if (isDead) return;
        hp--;

        if (hp <= 0)
        {
            isDead = true;
        }
    }
}
