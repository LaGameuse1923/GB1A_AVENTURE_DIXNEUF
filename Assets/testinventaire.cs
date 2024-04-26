using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventaire : MonoBehaviour
{

    public int Ames;

    public static inventaire instance;
    //voir booléen
    public bool clée;
    public bool plusdedificulté;
    public bool projectil;

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
    }

    public void Getclee()
    {
        clée = true;
    }

    public void Dificulté()
    {
        plusdedificulté = true;
    }
    public void GetProjectil()
    {
        projectil = true;
    }
}
