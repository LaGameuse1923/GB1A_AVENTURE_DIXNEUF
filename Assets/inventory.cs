using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public int Ames;

    public static inventory instance;
    //voir bool�en
    public bool cl�e;
    public bool plusdedificult�;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("2 inventaire");
            return;
        }
        instance = this;
    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddAmes(int _ame)
    {
        Debug.Log("plusAme");
        Ames += _ame; 
    }

    public void Getclee()
    {
       cl�e = true;
    }

    public void Dificult�()
    {
        plusdedificult� = true;
    }
}
