using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hache : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToDestroy;

    private void Update()
    {
        if (inventaire.instance.hache == true)
        {
            Destroy(objectToDestroy);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.CompareTag("Player"))
        {
            Destroy(objectToDestroy);
            inventaire.instance.Gethache();
        }
    }
}
