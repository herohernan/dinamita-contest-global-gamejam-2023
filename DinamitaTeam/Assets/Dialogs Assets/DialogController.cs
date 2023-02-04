using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
    private List<string> onShowingDialogs;
    private int nextDialogToShow;
    private TextMeshProUGUI dialogText; 

    // Start is called before the first frame update
    void Start()
    {

        this.gameObject.transform.Find("Square").gameObject.GetComponent<Image>().enabled = GlobalStore.onDialog;
        dialogText = this.gameObject.GetComponentInChildren<TextMeshProUGUI>();
        this.dialogText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalStore.onDialog)
        {
            this.gameObject.transform.Find("Square").gameObject.GetComponent<Image>().enabled = GlobalStore.onDialog;
            if (this.onShowingDialogs != GlobalStore.ActiveDialog)
            {
                this.onShowingDialogs = GlobalStore.ActiveDialog;
                this.onShowingDialogs.Add("");
                this.nextDialogToShow = 0;
                this.dialogText.text = this.onShowingDialogs[this.nextDialogToShow];
                this.nextDialogToShow += 1;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(this.onShowingDialogs[this.nextDialogToShow] == "")
                {
                    this.dialogText.text = this.onShowingDialogs[this.nextDialogToShow];
                    GlobalStore.onDialog = false;
                    this.gameObject.transform.Find("Square").gameObject.GetComponent<Image>().enabled = GlobalStore.onDialog;
                    return;
                }
                this.dialogText.text = this.onShowingDialogs[this.nextDialogToShow];
                this.nextDialogToShow += 1;
            }

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    this.gameObject.transform.Find("Square").gameObject.SetActive(false);
            //}

            //this.gameObject.transform.Find("Square").gameObject.SetActive(GlobalStore.onDialog);
            //if (this.onShowingDialogs != GlobalStore.ActiveDialog)
            //{
            //    this.onShowingDialogs = GlobalStore.ActiveDialog;
            //    this.dialogToShow = 0;
            //    this.dialogText.text = this.onShowingDialogs[this.dialogToShow];
            //    this.dialogToShow += 1;
            //}
            //if (Input.GetKeyDown(KeyCode.Space) && this.dialogToShow > this.onShowingDialogs.Count - 1)
            //{
            //    Debug.Log("DESACTIVANDO");
            //    GlobalStore.onDialog = false;
            //    GlobalStore.ActiveDialog = null;
            //    this.gameObject.transform.Find("Square").gameObject.SetActive(GlobalStore.onDialog);

            //    this.dialogText.text = this.onShowingDialogs[this.dialogToShow];
            //    this.dialogToShow += 1;

            //}
        }



    }
}
