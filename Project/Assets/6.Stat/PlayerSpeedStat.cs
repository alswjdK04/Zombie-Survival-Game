using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeedStat : MonoBehaviour
{
    public string PlayerSpeed; // ������ �̸�
    public int currentLevel = 1; // ���� ���� ����
    public int maxLevel = 5; // ������ �ִ� ����
    public float basePlayerSpeed = 5.0f; // �⺻ �̵� �ӵ�
    public float PlayerSpeedIncrease = 1.0f; // �� ������ �̵� �ӵ� ������

    // ���� ���׷��̵带 ó���ϴ� �Լ�
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // �� �������� �̵� �ӵ��� ����
            basePlayerSpeed += PlayerSpeedIncrease;
        }
    }

    // ���� �̵� �ӵ� ��ȯ
    public float GetMovementSpeed()
    {
        return basePlayerSpeed;
    }
}
