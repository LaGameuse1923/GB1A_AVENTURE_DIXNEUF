using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public int �mes;

    public static inventory instance;
    //voir bool�en
    public bool cl�e;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("2 inventaire");
            return;
        }
        instance = this;
    }

    public void AddAmes(int �me)
    {
        �mes += �me; 
    }

    public void Getclee()
    {
       cl�e = true;
    }
}
