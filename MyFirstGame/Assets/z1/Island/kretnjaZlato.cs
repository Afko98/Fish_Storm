using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kretnjaZlato : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2.35f)
        {
            transform.position = new Vector2(transform.position.x, -2.35f);
        }
        if (transform.position.y > 0.7f)
        {
            transform.position = new Vector2(transform.position.x, 0.69f);
        }
        if (transform.position.x > 2.4f)
        {
            transform.position = new Vector2(2.39f, transform.position.y);
        }
        if (transform.position.x < -2.4f)
        {
            transform.position = new Vector2(-2.39f, transform.position.y);
        }
    }
}
