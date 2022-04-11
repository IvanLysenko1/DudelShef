using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlatform : MonoBehaviour
{    
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DudelShef" )
        {
            //Случайная позиция платформы по Х
            float RandX = Random.Range(-1.7f, 1.7f);
            //Случайная позиция платформы по Y с наращиванием от крайней сверху платформы
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);
            //Позиция платформы новый вектор
            transform.position = new Vector3(RandX, RandY, 0);

            Сounter.instanceCount.ScoreCounter++;

        }
    }
}
