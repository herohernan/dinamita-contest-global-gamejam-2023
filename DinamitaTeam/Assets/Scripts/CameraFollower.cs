using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] public Transform target;
    public Vector3 offset = new Vector3(0.0f, 0.0f, -10.0f);
    public float smoothTime = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var currentVelocityRef = Vector3.zero;
        var targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocityRef, smoothTime);
    }
}
