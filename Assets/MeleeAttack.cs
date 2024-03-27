using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    //private Animator animator;
    [SerializeField] private BoxCollider2D hitbox;

    private void Start()
    {
        //animator = GetComponent<Animator>();
        hitbox = transform.Find("HitboxGameObjectName").GetComponent<BoxCollider2D>();
        BugAttack();
    }

    private void Update()
    {
        //DeactivateHitbox();


        if (Input.GetKeyDown(KeyCode.Space)) // Attack on Space key press.
        {
            
            //animator.SetTrigger("MeleeAttack");
            Debug.Log("espace");
            Invoke("ActivateHitbox", 0.2f); // Activate hitbox after 0.2 seconds.
            Invoke("DeactivateHitbox", 0.4f); // Deactivate hitbox after 0.4 seconds.
        }
    }

    void BugAttack()
    {
        Debug.Log("espace");
        Invoke("ActivateHitbox", 0.2f); // Activate hitbox after 0.2 seconds.
        Invoke("DeactivateHitbox", 0.4f); // Deactivate hitbox after 0.4 seconds.
    }

    void ActivateHitbox()
    {
        hitbox.gameObject.SetActive(true);
    }

    void DeactivateHitbox()
    {
        hitbox.gameObject.SetActive(false);
    }
}