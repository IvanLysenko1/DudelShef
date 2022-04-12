using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    //Обьект для  экрана паузы
    [SerializeField]
    GameObject pause;
    void Start()
    {
        //При запуске сцены экран не активен
        pause.SetActive(false);
    }
    //Для кнопки - ButtonPause (тап по экрану)
    public void PauseOn()
    {
        //активация экрана паузы
        pause.SetActive(true);
         //остановка времени в игре
        Time.timeScale = 0;       
    }
    //Для кнопки - продолжить играть
    public void PauseOff()
    {
        //отключение экрана паузы
        pause.SetActive(false);
        //запуск времени в игре
        Time.timeScale = 1;
    }
    //Для кнопки - Переход в меню
    public void GoToMenu()
    {
        //Переключение между сценами
        SceneManager.LoadScene(0);
        //запуск времени в игре
        Time.timeScale = 1;
    }
}
