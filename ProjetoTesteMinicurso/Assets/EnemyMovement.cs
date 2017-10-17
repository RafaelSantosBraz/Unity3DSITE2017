using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    float speedX = 0, speedZ = 0;
	// Use this for initialization
	void Start () {
        InvokeRepeating("ChangeDirection", 5f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(speedX * Time.deltaTime, 0, speedZ * Time.deltaTime);
	}

    void ChangeDirection()
    {
        speedX = Random.Range(-10, 10);
        speedZ = Random.Range(-10, 10);
    }
}
