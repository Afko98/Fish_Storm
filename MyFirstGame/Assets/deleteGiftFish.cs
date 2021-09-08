using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteGiftFish : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag!="chest" && collider.gameObject.tag!="music")
        Destroy(collider.gameObject);
    }

    
}
