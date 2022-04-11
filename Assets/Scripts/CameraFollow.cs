using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //ѕеременна€ дл€ позиции дудла
    public Transform dudlePos;

    void Update()
    {
        //”словие дл€ следовани€ камеры за дудлом , только по Y
       if(dudlePos.position.y> transform.position.y)
        {
            //ѕрив€зывание центра камеры за дудлом по Y
            transform.position = new Vector3(transform.position.x, dudlePos.position.y, transform.position.z);
        }
    }
}
