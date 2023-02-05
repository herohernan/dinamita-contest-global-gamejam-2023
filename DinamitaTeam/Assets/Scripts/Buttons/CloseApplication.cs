using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseApplication : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var buttonAction = this.gameObject.GetComponent<Button>();
        buttonAction.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("QUIT POR ESCAPE");
        }
    }

    // Button click action 
    void TaskOnClick()
    {
        Application.Quit();
        Debug.Log("QUIT POR CLICK");
    }
}
