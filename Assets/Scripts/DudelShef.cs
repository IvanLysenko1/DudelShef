using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DudelShef : MonoBehaviour
{
    //Переменная для использования DudleRigid в других скриптах
    public static DudelShef instance;
    //Переменная для акселерометра
    float horizontal;
    //переменная для тела дудла
    public Rigidbody2D DudleRigid;
    void Start()
    {   //Условие для статичности    
        if (instance == null)
        {
            instance = this;
        }
    }

    //Управление (FixedUpdate для стабильности)
    void FixedUpdate()
    {
        //Подключение акселеометра по оси Х ( тип Андроид)
        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }
        //Поворот дудла влево при наклоне < 0
        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        //Поворот дудла вправо при наклоне > 0
        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        //Сила наклона
        DudleRigid.velocity = new Vector2(Input.acceleration.x * 10f, DudleRigid.velocity.y);

        if (transform.position.x < -10)
            transform.position = new Vector3(transform.position.x + 20f, transform.position.y, transform.position.z);
        else if (transform.position.x > 10)
            transform.position = new Vector3(transform.position.x - 20f, transform.position.y, transform.position.z);
        

    }
    //Смерть и переход дудла
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Условие смерти дудла
        if (collision.collider.name == "DeadZone")
        {
            //Перезапуск сцены
            SceneManager.LoadScene(0);
        }

    }
}
