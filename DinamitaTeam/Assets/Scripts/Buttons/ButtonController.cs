using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor.SearchService;
using UnityEditor;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public SceneAsset nextScene; 

    // Start is called before the first frame update
    void Start()
    {  
        var buttonAction = this.gameObject.GetComponent<Button>();
        buttonAction.onClick.AddListener(TaskOnClick);  
    }

    // Button click action 
    void TaskOnClick()
    {
        SceneManager.LoadScene(nextScene.name);
    }

}
