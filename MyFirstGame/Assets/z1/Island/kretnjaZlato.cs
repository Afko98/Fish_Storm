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
    }
}
