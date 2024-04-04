using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public int Âmes;

    public static inventory instance;
    //voir booléen
    public bool clée;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("2 inventaire");
            return;
        }
        instance = this;
    }

    public void AddAmes(int âme)
    {
        Âmes += âme; 
    }

    public void Getclee()
    {
       clée = true;
    }
}
