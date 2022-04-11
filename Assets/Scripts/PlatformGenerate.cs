using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    //���������� ��� ������� ���������
    public GameObject platformPrefab;

    private void Start()
    {
        //������� �������� 
        Vector3 SpawnerPosition = new Vector3();
        //���� ��� �������� ��������, ��� ����������� i - �� ���������� 
        for (int i = 0; i < 10; i++)
        {
            //��������� ������� �� x  ��� �������� ���������
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);
            //��������� ������� �� y ��� �������� �������� (+= � ������������ Y)
            SpawnerPosition.y += Random.Range(2f, 4f);
            //C������� ���������
            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }

    private void Update()
    {
        
    }
}
