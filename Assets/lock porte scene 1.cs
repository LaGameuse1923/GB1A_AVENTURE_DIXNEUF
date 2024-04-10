using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockportescene1 : MonoBehaviour
{
    public GameObject objectToDestroy;
    public string nomDeLaPorte;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nomDeLaPorte == "porte âme")
        {
            if (inventory.instance.Âmes >= 10)
            {
                Destroy(objectToDestroy);
            }
        }
        if (nomDeLaPorte == "porte clée"){
            if (inventory.instance.clée)
            {
                Destroy(objectToDestroy);
             }
        }
    }
}
