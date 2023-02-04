using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAsDialogObj : MonoBehaviour
{
    public List<string> dialog;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D collider = this.gameObject.AddComponent<BoxCollider2D>();
        Rigidbody2D rigid_body = this.gameObject.AddComponent<Rigidbody2D>();
        this.gameObject.tag = "DialogObj";


        rigid_body.gravityScale = 0;
        collider.isTrigger = true;
        
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("every frame");
        //&& 
        if (Input.GetKeyDown(KeyCode.Space) && other.gameObject.tag == "Player")
        {
            GlobalStore.onDialog = true;
            GlobalStore.ActiveDialog = this.dialog;
            Debug.Log(GlobalStore.ActiveDialog[0]);
        }

    }    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GlobalStore.onDialog = false;
            GlobalStore.ActiveDialog = new List<string> { };
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
