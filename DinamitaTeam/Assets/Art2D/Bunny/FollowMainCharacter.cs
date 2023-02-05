using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMainCharacter : MonoBehaviour
{

    public GameObject character; //el target  chobjetivo
    public float moveSpeed = 5; //velocidad de movimiento
    private Rigidbody rb;
    //private Vector3 mytransform = character;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }
}




// SEGUNDO SCRIP DE PRUEBA

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class FollowMainCharacter : MonoBehaviour
//{

//    public Transform [] character; //el target  chobjetivo
//    public float Speed; //velocidad de movimiento
//    private int current;
//    private Vector3 mytransform = character;

//    // Start is called before the first frame update
//    void Start()
//    {
      
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (transform.position != character[current].position)
//        {
//            Vector3 pos = Vector3.MoveTowards(transform.position, character[current].position, speed * Time.deltaTime);
//            GetComponent<Rigidbody>().MovePosition(pos);
//        }
//        else current = (current + 1) % character.Length;
//    }
//}