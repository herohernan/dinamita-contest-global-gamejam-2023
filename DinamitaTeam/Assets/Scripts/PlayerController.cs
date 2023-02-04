using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xVelocity = 10.0f;

    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Option #1
        /*Vector3 translation = new Vector3();
        if (Input.GetKey(KeyCode.RightArrow))
        {
            translation = new Vector3(xVelocity * Time.deltaTime, 0.0f, 0.0f);
            transform.Translate(translation);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            translation = new Vector3(-xVelocity * Time.deltaTime, 0.0f, 0.0f);
            transform.Translate(translation);
        }*/

        // Option #2
        /*var xAxis = Input.GetAxis("Horizontal");
        transform.Translate(xAxis * xVelocity * Time.deltaTime, 0.0f, 0.0f);*/

        // Option #3
        Vector3 translation = new Vector3();
        if (Input.GetKey(KeyCode.RightArrow))
        {
            translation = new Vector3(xVelocity, 0.0f, 0.0f);
            rigidBody.AddForce(translation);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            translation = new Vector3(-xVelocity, 0.0f, 0.0f);
            rigidBody.AddForce(translation);
        }
        else
        {
            translation = Vector3.zero;
            rigidBody.velocity = translation;
        }
    }
}
