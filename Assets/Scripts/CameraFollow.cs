using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //���������� ��� ������� �����
    public Transform dudlePos;

    void Update()
    {
        //������� ��� ���������� ������ �� ������ , ������ �� Y
       if(dudlePos.position.y> transform.position.y)
        {
            //������������ ������ ������ �� ������ �� Y
            transform.position = new Vector3(transform.position.x, dudlePos.position.y, transform.position.z);
        }
    }
}
