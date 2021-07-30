
using UnityEngine;

public class spawnMjehurici : MonoBehaviour
{

    

    public Vector3 pos2 = Camera.main.transform.position;
    public GameObject stranaKlon, sredinaKlon, linijaKlon, strana, sredina, linija;


    void Update()
    {
        Vector3 pos1 = Camera.main.transform.position;

        if (pos1.y < pos2.y)
        {
            for (int i = 0; i < Random.Range(0f, 2.6f); i++) {
                stranaKlon = Instantiate(strana, new Vector2(Random.Range(0, 2) * 3.2f - 1.6f, pos2.y - 5.12f - Random.Range(0f, 50f) / 6f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            }
            pos2.y -= 5.12f;
        }
    }

}
