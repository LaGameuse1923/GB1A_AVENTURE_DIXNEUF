using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clée : MonoBehaviour
{

    public GameObject objectToDestroy;

    private void Update()
    {
        if (inventaire.instance.clée == true)
        {
            Destroy(objectToDestroy);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
     


        if (collision.CompareTag("Player"))
        {
            Destroy(objectToDestroy);
            inventaire.instance.Getclee();
        }
    }
}