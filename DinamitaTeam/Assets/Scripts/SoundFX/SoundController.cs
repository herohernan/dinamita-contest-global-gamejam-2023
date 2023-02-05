using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    void PlayStepsSounds()
    {
        GetComponent<AudioSource>().Play();
    }

    void StopStepsSounds()
    {
        GetComponent<AudioSource>().Stop();
    }
}
