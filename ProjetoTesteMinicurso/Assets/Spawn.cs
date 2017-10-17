using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameObject enemy;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn1", 5f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Spawn1()
    {
        GameObject temp = Instantiate(enemy);
        float range = Random.Range(1, 5);
        temp.transform.localScale = new Vector3(range,range, range);        
    }
}
