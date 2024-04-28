
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum PlayerState
{
    walk,
    Attack,
    interact
}

public class moveplayer : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftKey = KeyCode.LeftArrow, rightKey = KeyCode.RightArrow;

    [SerializeField]

    public Rigidbody2D rb;
    public PlayerState currentState;
    public GameObject playerPosition;



    private Vector3 velocity = Vector3.zero;
    private float horizontalMovement;
    private float verticalMovement;
    public float speed;
    private Vector3 change;
    public int avantindex;
    private Animator animator;
    public PlayerHealth playerHealth;
    public GameObject projectile;

    private string SceneDeSpawn;
    // Start is called before the first frame update


    private void Start()
    {
        currentState = PlayerState.walk;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        //verticalMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        //MovePlayer(horizontalMovement, verticalMovement);

        animator = GetComponent<Animator>();
        float characterVelocity = Mathf.Abs(rb.velocity.x);

        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        
      
        
            if (Input.GetButtonDown("Attack") && currentState != PlayerState.Attack)
            {
                if (inventaire.instance.hache == true)
                {
                    StartCoroutine(AttackCo());
                }


            }
        
        else if (currentState == PlayerState.walk)
        {
            UpdateAnimationAndMove();
        }


        if (Input.GetKeyDown(KeyCode.F))
        {
            if (inventaire.instance.projectil == true)
            {
                tirer();
            }
        }
    } 
    
    private IEnumerator AttackCo()
    {
        animator.SetBool("attack", true);
        currentState = PlayerState.Attack;
        yield return null;
        animator.SetBool("attack", false);
        yield return new WaitForSeconds(.33f);
        currentState = PlayerState.walk;

    }
    void UpdateAnimationAndMove(){
    
            if(change != Vector3.zero)
            {
                MoveCharacter();
                animator.SetFloat("moveX", change.x);
                animator.SetFloat("moveY", change.y);
                animator.SetBool("mouvement", true);
            }
            else
            {
                animator.SetBool("mouvement", false);
            }
    }



    

    void MoveCharacter()
    {
        rb.MovePosition(transform.position + change * speed * Time.fixedDeltaTime
            );

    }

    void tirer()
    {
        Instantiate(projectile, playerPosition.transform.position, Quaternion.identity);

    }




    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("scene change"))
        {

            avantindex = SceneManager.GetActiveScene().buildIndex;
            Debug.Log("index");


            //SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
            //SceneManager.UnloadSceneAsync("Scene1");

        }




    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hello ^^ ");
            playerHealth.TakeDamage(1);
        }
    }


       // {
       //     if (inventaire.instance.projectil == true)
         //   {
            //    tirer();













    //void MovePlayer(float _horizontalMovement, float _verticalMovement)
    //{
    // Vector3 targetVelocity = new Vector2(_horizontalMovement, _verticalMovement);
    // rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);


    // }

}


