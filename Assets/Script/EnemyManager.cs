using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    public float spawnTime = 50000;
    float timeCounter = 0.0f;

    public GameObject enemy;
    
	// Update is called once per frame
	void Update () {
        timeCounter += Time.deltaTime;
        if (timeCounter > spawnTime)
        {
            timeCounter = 0.0f;

            float x = Random.Range(-20.0f, 20.0f);
            float z = Random.Range(-20.0f, 20.0f);

            Instantiate(enemy, 
                new Vector3(x, 0.5f, z), Quaternion.identity);
        }
	}
}
