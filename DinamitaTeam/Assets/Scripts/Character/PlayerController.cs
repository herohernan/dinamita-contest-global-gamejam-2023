using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerController : MonoBehaviour
{
    public float xVelocity = 5.0f;

    private Rigidbody2D rigidBody;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        animator = this.gameObject.GetComponent<Animator>();
        this.gameObject.tag = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("IntroScene");
        }

        Vector3 translation = new Vector3();
        if (Input.GetKey(KeyCode.RightArrow))
        {
            translation = new Vector3(xVelocity, 0.0f, 0.0f);
            transform.eulerAngles = new Vector2(0, 0);
            animator.SetBool("Walking",true);
            rigidBody.velocity = translation;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            translation = new Vector3(-xVelocity, 0.0f, 0.0f);
            transform.eulerAngles = new Vector2(0, 180);
            animator.SetBool("Walking", true);
            rigidBody.velocity = translation;
        }
        else
        {
            translation = Vector3.zero;
            animator.SetBool("Walking", false);
            rigidBody.velocity = translation;
        }
    }
}
