using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision);
        //&& Input.GetButtonDown("Fire 1")
        if (collision.gameObject.tag == "DialogObj")
        {        
            GlobalStore.onDialog = true;
            GlobalStore.activeDialog = collision.gameObject.GetComponent<setAsDialogObj>().dialog;
            Debug.Log(GlobalStore.activeDialog);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DialogObj")
        {
            GlobalStore.onDialog = false;
            GlobalStore.activeDialog = "";
        }

    }
}
