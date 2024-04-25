
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveplayer : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftKey = KeyCode.LeftArrow, rightKey = KeyCode.RightArrow;

    [SerializeField]

    public Rigidbody2D rb;

    public GameObject playerPosition;



    private Vector3 velocity = Vector3.zero;
    private float horizontalMovement;
    private float verticalMovement;
    public float speed;
    private Vector3 change;
    public int avantindex;
    private Animator animator;
    private PlayerHealth playerHealth;
    public GameObject projectile;

    private string SceneDeSpawn;
    // Start is called before the first frame update


    private void Start()
    {
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

        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if(change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            tirer(); 
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


    void test()
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

    //void MovePlayer(float _horizontalMovement, float _verticalMovement)
    //{
    // Vector3 targetVelocity = new Vector2(_horizontalMovement, _verticalMovement);
    // rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);


    // }

}


