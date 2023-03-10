using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;

public class InteractiveObjController : MonoBehaviour
{
    public List<string> dialog;
    public TextMeshProUGUI DialogTextObj;
    public bool isTeleportItem;
    public string sceneName;
    public GameObject player; 

    private int nextText = 0;
    private bool IsTriggering = false;

    // On trigger Enter
    private void OnTriggerEnter2D(Collider2D other)
    {
        DialogTextObj.text = "";
    }

    // On trigger Stay
    private void OnTriggerStay2D(Collider2D other)
    {
        IsTriggering = true;
    }

    // On trigger Exit
    private void OnTriggerExit2D(Collider2D collision)
    {
        DialogTextObj.text = "";
        IsTriggering = false;
        nextText = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTriggering == true && Input.GetKeyDown(KeyCode.Space))
        {
            if(nextText < dialog.Count)
            {
                DialogTextObj.text = dialog[nextText];
                nextText++;
            }
            else
            {
                DialogTextObj.text = "";
                nextText=0;
                if (isTeleportItem)
                {
                    SceneManager.LoadScene(sceneName);
                    GlobalStore.PlayerPosition = new Vector2(player.transform.position.x, player.transform.position.y);
                }
            }
        }
    }
}
