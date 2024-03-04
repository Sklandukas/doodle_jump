using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float speed = .3f;
    void Start()
    {
        
    }

    void Update()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, speed);
        }
    }
}
