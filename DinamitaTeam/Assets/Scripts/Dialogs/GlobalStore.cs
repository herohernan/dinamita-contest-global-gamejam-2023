using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalStore : MonoBehaviour
{
    public static bool onDialog = false;
    public static List<string> ActiveDialog = new List<string> {""};
}