using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kretnjaRibe : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        if(Camera.main.transform.position.y < 2.1f)
        if(transform.rotation.y==0f)
                GetComponent<Rigidbody2D>().velocity = new Vector3(0.26f, 0f, 0f);
                else
                GetComponent<Rigidbody2D>().velocity = new Vector3(-0.26f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (transform.tag != "uhvacena")
        {
                

            if (transform.position.x < -3f && transform.position.x>-5f)
            {
                transform.rotation = transform.rotation * Quaternion.Euler(0f, -180f, 0f);
                transform.position = new Vector3(-2.9f, transform.position.y, transform.position.z);
                GetComponent<Rigidbody2D>().velocity = new Vector3(0.26f, 0f, 0f);
            }
            if (transform.position.x > 3f)
            {
                transform.rotation = transform.rotation * Quaternion.Euler(0f, 180f, 0f);
                transform.position = new Vector3(2.9f, transform.position.y, transform.position.z);
                GetComponent<Rigidbody2D>().velocity = new Vector3(-0.26f, 0f, 0f);
            }
        }
    }
}
