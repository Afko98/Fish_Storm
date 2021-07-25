using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject zid1, zid1d;
    private Transform playerTransform;
    
    public Vector3 pos2 = Camera.main.transform.position;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 pos1 = Camera.main.transform.position;
        
        if (pos1.y <= pos2.y+5.12f)
        {
            Instantiate(zid1, new Vector2(-0.256f, pos2.y - 2.56f - 5.12f),Quaternion.identity);
            Instantiate(zid1d, new Vector2(0.256f, pos2.y - 2.56f - 5.12f),Quaternion.identity);
            pos2.y -= 5.12f;
        }
    }
}
