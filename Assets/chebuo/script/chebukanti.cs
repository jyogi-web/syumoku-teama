using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chebukanti : MonoBehaviour
{
    public static bool chebukenin = false;
    int chebuken = 0;
    public GameObject chebuspawner;
    ImageInstantiate imageinstantiate;
    // Start is called before the first frame update
    void Start()
    {
        imageinstantiate = chebuspawner.GetComponent<ImageInstantiate>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("chebuken"))
        {
            chebuken++;Debug.Log(chebuken);
           
        }
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(ImageInstantiate.chebuken);
        if (chebuken == ImageInstantiate.chebuken&&ImageInstantiate.chebuken>=1)
        {
            chebukenin = true;
            Debug.Log(chebukenin);
        }
        else
        {
            chebukenin = false;
        }
    }
}
