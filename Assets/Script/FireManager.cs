﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour {
    public Transform cameraTransform;
    public GameObject fireObject;
    public Transform firePosition;
    public float power = 20.0f;

    public Animator bazooka;

	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            if (gameObject.GetComponent<PlayerState>().isDead)
            {
                return;
            }

            GameObject temp = Instantiate(fireObject);

            temp.transform.position = 
                firePosition.position;

            temp.GetComponent<Rigidbody>().velocity =
                cameraTransform.forward * power;

            bazooka.SetTrigger("Shoot");

            gameObject.GetComponent<PlayerState>().hp--;
        }
	}
}
