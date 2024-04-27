using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class inventory : MonoBehaviour
{
    public int Ames;
    public Text AmesText;

    public static inventory instance;
    //voir booléen
    public bool clée;
    public bool plusdedificulté;

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
        ajoutAmes();
           
    }

    public void ajoutAmes()
    {
        AmesText.text = Ames.ToString();
    }

    public void Getclee()
    {
       clée = true;
    }

    public void Dificulté()
    {
        plusdedificulté = true;
    }
}
