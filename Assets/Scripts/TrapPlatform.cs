using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlatform : MonoBehaviour
{    
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DudelShef" )
        {
            //��������� ������� ��������� �� �
            float RandX = Random.Range(-1.7f, 1.7f);
            //��������� ������� ��������� �� Y � ������������ �� ������� ������ ���������
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);
            //������� ��������� ����� ������
            transform.position = new Vector3(RandX, RandY, 0);

            �ounter.instanceCount.ScoreCounter++;

        }
    }
}
