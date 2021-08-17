using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kretnjaAkvarijum : MonoBehaviour
{
    int p = 0;
    int i = 1;
    // Start is called before the first frame update
    private void Start()
    {
        if (transform.rotation.y == 0f)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0.2f, 0f, 0f);
            i = 1;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-0.2f, 0f, 0f);
            i = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {

        p++;
        transform.position = new Vector2(transform.position.x+(i * 0.0003f), transform.position.y + ((0.0002f) * Mathf.Cos(p / 320f + transform.position.x + transform.position.y)));

        if (transform.position.x < -2.4f && transform.position.x>-2.8f)
        {
            transform.rotation = transform.rotation * Quaternion.Euler(0f, -180f, 0f);
            transform.position = new Vector3(-2.38f, transform.position.y, transform.position.z);
            i = 1;
            
        }
        if (transform.position.x > 2.4f)
        {
            transform.rotation = transform.rotation * Quaternion.Euler(0f, 180f, 0f);
            transform.position = new Vector3(2.38f, transform.position.y, transform.position.z);
            i = -1;
            
        }
        if (transform.position.y > 0.9)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -4f, 0f);
        }
        if (transform.position.y < -2.46f)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 4f, 0f);
        }
        if (transform.position.x < -2.9f)
        {
            transform.position = new Vector2(-10f, -10f);
        }
        
    }
    }
