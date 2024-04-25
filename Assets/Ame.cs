using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ame : MonoBehaviour
{
    public GameObject objectToDestroy;
    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.CompareTag("Player"))
        {
            Destroy(objectToDestroy);
            inventory.instance.AddAmes(1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
