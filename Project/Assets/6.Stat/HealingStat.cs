using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingStat : MonoBehaviour
{
    public string Healing; // ������ �̸�
    public int currentLevel = 1; // ���� ���� ����
    public int maxLevel = 5; // ������ �ִ� ����
    public float baseHealing = 5.0f; // �⺻ ȸ����
    public float healingIncrease = 0.1f; // �� ������ ȸ���� ������

    // ���� ���׷��̵带 ó���ϴ� �Լ�
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // �� �������� ȸ������ ����
            baseHealing += healingIncrease;
        }
    }

    // ���� ȸ���� ��ȯ
    public float GetHealingRate()
    {
        return baseHealing;
    }
}
