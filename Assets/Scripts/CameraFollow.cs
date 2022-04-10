using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform dudlePos;

    void Update()
    {
       if(dudlePos.position.y> transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, dudlePos.position.y, transform.position.z);
        }
    }
}
