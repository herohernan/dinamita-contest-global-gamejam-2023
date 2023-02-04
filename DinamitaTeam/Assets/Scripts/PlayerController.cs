using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xVelocity = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 translation = new Vector3();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            translation = new Vector3(xVelocity * Time.deltaTime, 0.0f, 0.0f);
            transform.Translate(translation);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            translation = new Vector3(-xVelocity * Time.deltaTime, 0.0f, 0.0f);
            transform.Translate(translation);
        } 
    }
}
