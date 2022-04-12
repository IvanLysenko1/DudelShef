using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCloud : MonoBehaviour
{
    //Переменная для силы прыжка
    public float forceJump;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Условие срабатывания прыжка (только при падении вниз)
        if (collision.relativeVelocity.y < 0)
        {
            //Прыжок дудла
            DudelShef.instance.DudleRigid.velocity = Vector2.up * forceJump;
        }       
    }
    //Перемещение скрытых платформ на вверх
    public void OnCollisionExit2D(Collision2D collision)
    {
        //Условие перемещения платформ 
        if (collision.collider.name == "DeadZone")
        {
            //Случайная позиция платформы по Х
            float RandX = Random.Range(-2.2f, 2.2f);
            //Случайная позиция платформы по Y с наращиванием от крайней сверху платформы
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);
            //Позиция платформы новый вектор
            transform.position = new Vector3(RandX, RandY, 0);
            //Накручиваем счетчик
            Сounter.instanceCount.ScoreCounter++;

        }
    }
}

