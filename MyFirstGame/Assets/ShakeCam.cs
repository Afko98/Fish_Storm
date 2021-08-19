using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCam : MonoBehaviour
{
    static public float shakeTime = 0.5f;
    Vector3 original;
    static public int shakePower=130;
    private void Start()
    {
        original = transform.position;
    }
    void Update()
    {
        if (uslovi.shake)
        {
                shakeTime -= Time.deltaTime;
            transform.position = new Vector3 (transform.position.x + Random.Range(-shakeTime / shakePower, shakeTime / shakePower), transform.position.y + Random.Range(-shakeTime/shakePower, shakeTime / shakePower),transform.position.z);
        }
        if (shakeTime < 0f)
        {
            uslovi.shake = false;
            
            transform.position = new Vector3(original.x, transform.position.y, transform.position.z);
        }
    }
}
