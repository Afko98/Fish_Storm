using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepthUpdateText : MonoBehaviour
{
    

    
    void Update()
    {
        gameObject.GetComponent<Text>().text = ""+(-(int)Camera.main.transform.position.y+1);
    }
}
