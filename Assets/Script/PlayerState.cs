using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour {
    public int hp = 20;
    public float scale = 1;
    public bool isDead = false;
    public Text hpText;
    public float regenDelta = 2;
    private float regenCounter = 0;

    void Start()
    {
        hpText.text = "My Health : " + hp;
    }

    void Update()
    {
        regenCounter += Time.deltaTime;
        if(!isDead && regenCounter > regenDelta && hp < 20)
        {
            HandleHp(1);
            regenCounter = 0;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Contains("Spider"))
        {
            Destroy(col.gameObject);
            HandleKill();
        }

        Destroy(gameObject);
    }

    public void HandleKill()
    {
        scale += 0.02f;
        transform.localScale = new Vector3(scale, scale, scale);
    }

    public void HandleHp(int inclement)
    {
        hp+= inclement;
        hpText.text = "My Health : " + hp;
        if (hp <= 0)
        {
            isDead = true;
            hpText.text = "Game Over";
        }
    }

	public void DamageByEnemy()
    {
        if (!isDead)
        {
            HandleHp(-1);
        }
    }
}
