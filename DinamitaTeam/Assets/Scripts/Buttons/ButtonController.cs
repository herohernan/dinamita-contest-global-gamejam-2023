using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class ButtonController : MonoBehaviour
{
    public string nextScene;

    // Start is called before the first frame update
    void Start()
    {
        var buttonAction = this.gameObject.GetComponent<Button>();
        buttonAction.onClick.AddListener(TaskOnClick);
    }

    // Button click action 
    void TaskOnClick()
    { 
        SceneManager.LoadScene(nextScene);
    }

}