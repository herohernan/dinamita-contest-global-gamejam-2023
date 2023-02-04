using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalStore : MonoBehaviour
{
    public static bool onDialog = false;


    public static string activeDialog;
    public static string ActiveDialog
    {
        get
        {
            return activeDialog;
        }
        set
        {
            Debug.Log("ActiveDialog: " + value);
            ActiveDialog = value;
        }
    }

}
