using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var pcResolution = Screen.currentResolution;
        Screen.SetResolution(pcResolution.width, pcResolution.height, FullScreenMode.ExclusiveFullScreen, 60);
    }
}
