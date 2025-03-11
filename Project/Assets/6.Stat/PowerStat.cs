using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerStat : MonoBehaviour
{
    public string Power; // ������ �̸�
    public int currentLevel = 1; // ���� ���� ����
    public int maxLevel = 5; // ������ �ִ� ����
    public float basePower = 10.0f; // �⺻ �Ŀ�
    public float powerIncreasePercentage = 10.0f; // ������ �Ŀ� ���� �ۼ�Ʈ

    // ���� ���׷��̵带 ó���ϴ� �Լ�
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // ������ �Ŀ� ���� �ۼ�Ʈ�� �����Ͽ� �Ŀ��� ������Ʈ
            basePower += (basePower * powerIncreasePercentage / 100);
        }
    }

    // ���� ���� �Ŀ� ��ȯ
    public float GetStatPower()
    {
        return basePower;
    }
}


