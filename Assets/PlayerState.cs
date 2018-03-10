using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour {
    public int hp = 20;
    public int scale = 1;
    public bool isDead = false;
    public Text hpText;

    void Start()
    {
        hpText.text = "My Health : " + hp;
    }

    public void HandleKill()
    {
        scale++;
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
            if (scale > 1)
            {
                scale--;
                transform.localScale = new Vector3(scale, scale, scale);
            }
            HandleHp(-1);
        }
    }
}
