using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaximumStaminaStat : MonoBehaviour
{
    public string MaximumStamina; // ������ �̸�
    public int currentLevel = 1; // ���� ���� ����
    public int maxLevel = 5; // ������ �ִ� ����
    public float baseMaximumStamina = 100.0f; // �⺻ �Ŀ�
    public float MaximumStaminaIncreasePercentage = 10.0f; // ������ �Ŀ� ���� �ۼ�Ʈ

    // ���� ���׷��̵带 ó���ϴ� �Լ�
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // ������ �Ŀ� ���� �ۼ�Ʈ�� �����Ͽ� �Ŀ��� ������Ʈ
            baseMaximumStamina += MaximumStaminaIncreasePercentage;
        }
    }

    // ���� ���� �Ŀ� ��ȯ
    public float GetMaximumStamina()
    {
        return baseMaximumStamina;
    }
}


