using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class depthSliderUpdate : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<Slider>().value= 1 + (Camera.main.transform.position.y - 1) / CameraMove.uze;
        if (Camera.main.transform.position.y > 2.7f)
            GameObject.FindGameObjectWithTag("depthBar").SetActive(false);
    }
}
