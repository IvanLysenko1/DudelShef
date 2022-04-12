using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Для кноаки - играть
    public void Play()
    {
        //Запуск игровой сцены
        SceneManager.LoadScene(1);
    }
    //Для кнопки - выход
    public void Quite()
    {
        //Выход из приложения
        Application.Quit();
    }
}
