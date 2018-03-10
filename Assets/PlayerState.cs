using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour {
    public int hp = 5;
    public bool isDead = false;
    public Text hpText;

    void Start()
    {
        hpText.text = "My Health : " + hp;
    }

	public void DamageByEnemy()
    {
        if (isDead) return;
        hp--;
        hpText.text = "My Health : " + hp;

        if (hp <= 0)
        {
            isDead = true;
            hpText.text = "GameOver";
        }
    }
}
