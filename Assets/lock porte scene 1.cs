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
        if (inventory.instance.�mes >= 1)
        {
            Destroy(objectToDestroy);
        }
        if (inventory.instance.cl�e)
        {
            Destroy(objectToDestroy);
        }
    }
}
