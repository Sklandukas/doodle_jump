using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManEffect : MonoBehaviour
{
    private float r_x = 3.77f;
    private float l_x = -3.7f;
    void Update()
    {
        Vector3 position = transform.position;
        if(position.x > r_x)
        {
            position.x = l_x;
            transform.position = position;
        }

        if(position.x < l_x)
        {
            position.x = r_x;
            transform.position = position;
        }
    }
}
