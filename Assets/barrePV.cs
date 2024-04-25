using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrePV : MonoBehaviour
{

    public int currentHealth;
    private Animator animator;


    // Start is called before the first frame update

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetMaxHealth(int health)
    {
        Debug.Log("Pvdebase");
        animator.SetFloat("Max PV", health);
    }

    public void SetHealth(int health)
    {
        currentHealth = health;
        Debug.Log("moinsdepv");
        animator.SetFloat("Max PV", currentHealth);
    }


}