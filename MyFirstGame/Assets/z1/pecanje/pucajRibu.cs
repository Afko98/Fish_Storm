using UnityEngine;

using System.Collections;
public class pucajRibu : MonoBehaviour
{
    public static int killed = 0;
    public static int brojMetaka = 2;
    public static int brM;
    public GameObject krv,krvKlon;
    int brMetakaMax;

    
    void Start()
    {
        brM = BrojMetaka.brojMetakaUIgri+brojMetaka;
        brMetakaMax = brM;
    }
    void Update()
    {
        brM = BrojMetaka.brojMetakaUIgri + brojMetaka;
        if (brM > brMetakaMax)
            brMetakaMax = brM;
    }
    private void OnMouseDown()
    {

        if (Camera.main.transform.position.y > 2 && brM > 0)
        {

            BrojMetaka.brojMetakaUIgri--;
            p();
           
        }
    }
    
    public void p()
    {
        
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 100f;

        Vector2 v = Camera.main.ScreenToWorldPoint(mousePosition);

        Collider2D[] col = Physics2D.OverlapPointAll(v);

        if (col.Length > 0)
        {
            foreach (Collider2D c in col)
            {
                if (BrojMetaka.brojMetakaUIgri < 1 && !uslovi.pogodjena && col.Length<2 && c.gameObject.tag!="uhvacena")
                    achivments.shootAll0Kill = true;

                if (c.gameObject.tag != "uhvacena")
                    continue;
                uslovi.pogodjena = true;
                if ( col.Length > 3)
                    achivments.kill3oneShot = true;
                if (col.Length > 5)
                    achivments.kill5OneShot = true;
                if (col.Length > 10)
                    achivments.kill10OneShot = true;
                
                killed++;
                uslovi.killedInOneGame++;

                if (uslovi.killedInOneGame >= 2 * brMetakaMax)
                    achivments.kill2x=true;
                if (uslovi.killedInOneGame >= 3 * brMetakaMax)
                    achivments.kill3x = true;
                if (uslovi.killedInOneGame >= 4 * brMetakaMax)
                    achivments.kill4x = true;

                if (killed > 99)
                    achivments.killed100 = true;
                if (killed > 499)
                    achivments.killed500 = true;
                if (killed > 1999)
                    achivments.killed2000 = true;

                //Debug.Log("Collided with: " + c.collider2D.gameObject.name);
                localMoney.localCoins -= (int)c.gameObject.transform.position.z;
                currency.allCurrency -= (int)c.gameObject.transform.position.z;
                krvKlon=Instantiate(krv, c.gameObject.transform.position, Quaternion.identity);
                krvKlon.GetComponent<Rigidbody2D>().velocity = c.gameObject.GetComponent<Rigidbody2D>().velocity;
                Destroy(c.gameObject);
                

            }
        }
    }
}
