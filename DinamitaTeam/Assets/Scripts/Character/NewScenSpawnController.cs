using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScenSpawnController : MonoBehaviour
{
    public GameObject player;
    private bool firstTimeInTheScript = false; 

    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = GlobalStore.PlayerPosition;
    }
}
