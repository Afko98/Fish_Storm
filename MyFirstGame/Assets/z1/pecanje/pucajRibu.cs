using UnityEngine;

using System.Collections;
public class pucajRibu : MonoBehaviour
{
    public GameObject go;

    private void OnMouseDown()
    {
       if (Camera.main.transform.position.y>2)
                p();
    }
    public void p()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 500f;

        Vector2 v = Camera.main.ScreenToWorldPoint(mousePosition);

        Collider2D[] col = Physics2D.OverlapPointAll(v);

        if (col.Length > 0)
        {
            foreach (Collider2D c in col)
            {
                //Debug.Log("Collided with: " + c.collider2D.gameObject.name);
                localMoney.localCoins -= (int)c.gameObject.transform.position.z;
                go.GetComponent<localMoney>().updateLocalCoins();
                Destroy(c.gameObject);
            }
        }
    }
}
