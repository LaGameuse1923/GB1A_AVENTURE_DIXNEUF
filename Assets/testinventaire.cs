using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventaire : MonoBehaviour
{

    public int Ames;
    public Text AmesText;

    public static inventaire instance;
    //voir bool�en
    public bool cl�e;
    public bool plusdedificult�;
    public bool projectil;
    public bool hache;

    // Start is called before the first frame update

    private void Awake()
    {
        if (instance != null)
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

    public void PlusAmes(int _ame)
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
        cl�e = true;
    }
    public void Gethache()
    {
        hache = true;
    }

    public void Dificult�()
    {
        plusdedificult� = true;
    }
    public void GetProjectil()
    {
        projectil = true;
    }
}
