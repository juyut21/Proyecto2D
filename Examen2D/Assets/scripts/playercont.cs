using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class playercont : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    public Vector3 Movimiento;
    public TextMeshProUGUI textMeshPro;
    public int count = 0;
    public Animator animator;

    

    private bool canJump = true;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canJump)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
                canJump = false;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            animator.SetBool("running", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            animator.SetBool("running", true);
        }

        if(!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            animator.SetBool("running", false);
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            canJump = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            SoundManager.PlaySound("Coin");
            count++;
            textMeshPro.text = "" + count;
        }
        if (collision.CompareTag("CoinRed"))
        {
            if(count != 0)
            {
                SoundManager.PlaySound("CoinRed");
                count--;
                textMeshPro.text = "" + count;
            }
        }
        PlayerPrefs.SetInt("Score", count);
    }

}
