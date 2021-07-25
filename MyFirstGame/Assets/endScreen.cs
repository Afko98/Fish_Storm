
using UnityEngine;
using UnityEngine.UI;

public class endScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject menu;
    
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        
        if (transform.position.y > 10.7f)
        {
            
            menu.SetActive(true);
        }
    }
}
