using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //pode utilizar private e serialized fild   

    public float speed;
    float speed2 = 17;
    public Slider slider;

    // Use this for initialization
    void Start()
    {
        GameObject.Find("Cap");
        transform.position = new Vector3(0, 0, 0);
        slider.minValue = 0;
        slider.maxValue = 100;
        slider.value = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && slider.value > 0)
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed2, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed2);
            slider.value -= 10 * Time.deltaTime;
        }
        else
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(0, 10, 0);
        }

    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "enemy")
        {
            if (c.gameObject.transform.localScale.x <= transform.localScale.x)
            {
                transform.localScale += new Vector3(c.transform.localScale.x, c.transform.localScale.y, c.transform.localScale.z);
                Destroy(c.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        if (c.gameObject.tag == "boost")
        {
            slider.value += 10;
        }
    }
}
