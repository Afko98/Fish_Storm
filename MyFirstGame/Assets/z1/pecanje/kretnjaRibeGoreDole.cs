using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kretnjaRibeGoreDole: MonoBehaviour
{
    float delta = 0;
    

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if (transform.tag != "uhvacena")
        {
            if (delta < 2)
                GetComponent<Rigidbody2D>().velocity = new Vector3(GetComponent<Rigidbody2D>().velocity.x, -0.16f, 0f);

            if (delta > 2)
                GetComponent<Rigidbody2D>().velocity = new Vector3(GetComponent<Rigidbody2D>().velocity.x, 0.16f, 0f);
            if (delta > 4)
                        delta = 0;
        }
    }
}
