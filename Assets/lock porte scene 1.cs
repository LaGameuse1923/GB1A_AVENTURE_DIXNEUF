using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockportescene1 : MonoBehaviour
{
    public GameObject objectToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inventory.instance.Âmes >= 1)
        {
            Destroy(objectToDestroy);
        }
        if (inventory.instance.clée)
        {
            Destroy(objectToDestroy);
        }
    }
}
