using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteGiftFish : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
