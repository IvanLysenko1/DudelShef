using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    //���������� ��� ������� ���������
    public GameObject platformPrefab;

    public int limitation;

    private void Start()
    {
        //������� �������� 
        Vector3 SpawnerPosition = new Vector3();
        //���� ��� �������� ��������, ��� ����������� i - �� ���������� 
        for (int i = 0; i < limitation; i++)
        {
            //��������� ������� �� x  ��� �������� ���������
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);
            //��������� ������� �� y ��� �������� �������� (+= � ������������ Y)
            SpawnerPosition.y += Random.Range(1f, 4f);
            //C������� ���������
            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }

    private void Update()
    {
        
    }
}
