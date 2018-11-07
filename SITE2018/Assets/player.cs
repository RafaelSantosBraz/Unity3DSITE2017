using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10;

    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 0, 0);
    }

    private void OnCollisionEnter(Collision c)
    {
        print("bateu" + c.gameObject.tag);
        if (c.gameObject.tag == "enemy")
        {
            if (gameObject.transform.localScale.x >= c.gameObject.transform.localScale.x)
            {
                gameObject.transform.localScale += c.gameObject.transform.localScale;
                Destroy(c.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        float x = transform.position.x;
        float z = transform.position.z;
        float y = transform.position.y;

        // print(Input.GetKey(KeyCode.RightArrow));
        //print(Input.GetAxis("Horizontal"));

        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.position = new Vector3(x + speed * Time.deltaTime * Input.GetAxis("Horizontal"), y + speed * Time.deltaTime, z + speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }
        else
        {
            gameObject.transform.position = new Vector3(x + speed * Time.deltaTime * Input.GetAxis("Horizontal"), y, z + speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }





        //print(gameObject.transform.position.x);
    }
}
