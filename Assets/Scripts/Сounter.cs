using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Сounter : MonoBehaviour
{
    //Делаем публичным класс, что бы изменять и использовать ScoreCounter
    public static Сounter instanceCount;
    //Для вывода в UI Text
    public Text ScoreText;
    //Переменная для подсчета
    public int ScoreCounter;
    void Start()
    {
        //Условие для статичности  
        if (instanceCount == null)
        {
            instanceCount = this;
        }
        //Приравниваем счетчик 0;
        ScoreCounter = 0;
    }
    void Update()
    {
        //Выводим количество пройденых платформ на экран
        ScoreText.text = ScoreCounter.ToString();
    }

}

