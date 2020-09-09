using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public float speedAnim;
    private Vector2 direction;
    BoxCollider2D kotak;
    SpriteRenderer sr;
    public GameObject player;
    public static GameObject p;
    public Animator anim;
    //bool nisor = false;

    // Start is called before the first frame update
    void Start()
    {
        p = player;
        sr = GetComponent<SpriteRenderer>();
        //player.SetActive(true);
        //DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //speed = 0;
        asolole();
        Obah();
    }

    public void Obah()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void Flip()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
        Vector2 flip = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0)
        {
            //flip.x = 12;
            sr.flipX = false;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = true;
        }
        //transform.localScale = flip;
        //sr.flipX = false;
    }

    private void asolole()
    {
        
        bool FlipChar = false;
        speedAnim = 0;
        direction = Vector2.zero;
        anim.SetBool("IsDown", false);
        anim.SetBool("Nyamping", false);
        anim.SetBool("Naek", false);


        if (Input.GetKey(KeyCode.UpArrow) && OnCollision.playerStop == false)
        {
            speedAnim = 4;
            direction = Vector2.up;
            anim.SetBool("Naek", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && OnCollision.playerStop == false)
        {
            FlipChar = true;
            speedAnim = 4;
            Flip();
            direction = Vector2.left;
            anim.SetBool("Nyamping", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && OnCollision.playerStop == false)
        {
            speedAnim = 4;
            Flip();
            direction = Vector2.right;
            anim.SetBool("Nyamping", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && OnCollision.playerStop == false)
        {
            speedAnim = 4;
            anim.SetBool("IsDown", true);
            direction = Vector2.down;
        }
        anim.SetFloat("Speed", speedAnim);
    }
}
