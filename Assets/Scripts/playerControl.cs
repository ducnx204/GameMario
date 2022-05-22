using System;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    public float jumHeigh1;
    public AudioSource aus;
    public AudioClip jumpSound;
    public AudioClip loseSound;
    public AudioClip bumjSound;

    // them chuc nangw//

    bool facingRight;
    bool isGround;


    Rigidbody2D myBody;
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        facingRight = true;



    }


    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal"); //di chuyển theo chiều ngang
        myBody.velocity = new Vector2(move * speed, myBody.velocity.y);
        // quay mặt khi di chuyển
        if (move > 0 && !facingRight) //khi đi qua phải và mặc bên trái thì quay mặt
        {
            flip();
            if (aus && bumjSound)
            {
                aus.PlayOneShot(bumjSound);
            }
           
        }
        else if (move < 0 && facingRight) // khi đi qua trái và mặt bên phải thì camera main ser qua trai
        {
            flip();
            if (aus && bumjSound)
            {
                aus.PlayOneShot(bumjSound);
            }
         
        }

        // chạy
        myAnim.SetFloat("running", Mathf.Abs(move));

        Jump();
        UpArrow();





    }

    // nhảy
    void Jump()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myAnim.SetBool("jump", true);
            if (isGround)
            {

                isGround = false;
                myBody.velocity = new Vector2(myBody.velocity.x, jumpHeight);

                if(aus && jumpSound)
                {
                    aus.PlayOneShot(jumpSound);
                }

            }

        }
        else myAnim.SetBool("jump", false);


     

    }

    void UpArrow()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myAnim.SetBool("jump", true);
            if (isGround )
            {

                isGround = true;
                myBody.velocity = new Vector2(myBody.velocity.x, jumHeigh1);


            }
        }
        else myAnim.SetBool("s", false);
    }
    // quay mặt
    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    // xử lí va chạm
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            gameObject.SetActive(false);

           GameControll.instance.GameOver();
            Time.timeScale = 0;

            if(aus && loseSound)
            {
                aus.PlayOneShot(loseSound);
            }
        }
    }
}
