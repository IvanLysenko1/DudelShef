using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{   //Создаем переменные Скорость и ограничения перемещения по Х "откуда до куда"
    public float Speed, MinX, MaxX;
    //Направление движения, поумолчанию вправо 
    private bool right;
    
    void Update()
    {
        //Условие движения вправо
        if(right && transform.position.x < MaxX)
        {
            //перемещение платформы вправо 
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }
        //Условие если дошли до правой границы 
        else if (right)
        {
            //изменение направления 
            right = false;
        }
        //Условие движения влево
        else if(!right && transform.position.x > MinX)
        {
            //перемещение платформы влнво
            transform.position -= Vector3.right * Speed * Time.deltaTime;
        }
        //Условие если дошли до левой границы
        else if (!right)
        {
            //изменение направления
            right = true;
        }
    }
}
