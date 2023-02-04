using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    private List<string> onShowingDialogs;
    private int dialogToShow;
    private TextMesh dialogText; 

    // Start is called before the first frame update
    void Start()
    {
        dialogText = this.gameObject.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalStore.onDialog)
        {
            /*if(this.onShowingDialogs != GlobalStore.ActiveDialog)
            {
                this.onShowingDialogs = GlobalStore.ActiveDialog;
                this.dialogToShow = 0;
                this.dialogText.text = this.onShowingDialogs[this.dialogToShow];
                this.dialogToShow += 1;
            }*/


            if (Input.GetKeyDown(KeyCode.Space) && this.dialogToShow <= this.onShowingDialogs.Count)
            {
                this.dialogText.text = this.onShowingDialogs[this.dialogToShow];
                this.dialogToShow += 1;
            }

            if(this.dialogToShow <= this.onShowingDialogs.Count)
            {
                GlobalStore.ActiveDialog = null;
                GlobalStore.onDialog = false;
            }

        }



    }
}
