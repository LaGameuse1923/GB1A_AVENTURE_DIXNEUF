using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 4;
    public int currentHealth;
    public barrePV barrepv;



        // Start is called before the first frame update
        void Start()
    {
        currentHealth = maxHealth;
        barrepv.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            TakeDamage(1);
        }
    }
    public void TakeDamage(int domage)
    {

        currentHealth -= domage;
        barrepv.SetHealth(currentHealth);
    }
}