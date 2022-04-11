using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DudelShef : MonoBehaviour
{
    //���������� ��� ������������� DudleRigid � ������ ��������
    public static DudelShef instance;
    //���������� ��� �������������
    float horizontal;
    //���������� ��� ���� �����
    public Rigidbody2D DudleRigid;
    void Start()
    {   //������� ��� �����������    
        if (instance == null)
        {
            instance = this;
        }
    }

    //���������� (FixedUpdate ��� ������������)
    void FixedUpdate()
    {
        //����������� ������������ �� ��� � ( ��� �������)
        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }
        //������� ����� ����� ��� ������� < 0
        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        //������� ����� ������ ��� ������� > 0
        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        //���� �������
        DudleRigid.velocity = new Vector2(Input.acceleration.x * 10f, DudleRigid.velocity.y);
    }
    //������ �����
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //������� ������ �����
        if (collision.collider.name == "DeadZone")
        {
            //���������� �����
            SceneManager.LoadScene(0);
        }
    }
}
