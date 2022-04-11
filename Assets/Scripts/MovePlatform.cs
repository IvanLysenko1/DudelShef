using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float Speed, MinX, MaxX;

    private bool right;
    
    void Update()
    {
        if(right && transform.position.x < MaxX)
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }
        else if (right)
        {
            right = false;
        }
        else if(!right && transform.position.x >MinX)
        {
            transform.position -= Vector3.right * Speed * Time.deltaTime;
        }
        else if (!right)
        {
            right = true;
        }
    }
}
