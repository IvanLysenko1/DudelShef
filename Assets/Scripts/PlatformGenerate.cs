using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    //Переменная для префаба платформы
    public GameObject platformPrefab;

    private void Start()
    {
        //Позиция спавнера 
        Vector3 SpawnerPosition = new Vector3();
        //Цикл для создания платформ, где ограничение i - их количество 
        for (int i = 0; i < 10; i++)
        {
            //Случайная позиция по x  для создания платформы
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);
            //Случайная позиция по y для создания платформ (+= с наращиванием Y)
            SpawnerPosition.y += Random.Range(2f, 4f);
            //Cоздание платформы
            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }

    private void Update()
    {
        
    }
}
