using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeedStat : MonoBehaviour
{
    public string BulletSpeed; // ������ �̸�
    public int currentLevel = 1; // ���� ���� ����
    public int maxLevel = 5; // ������ �ִ� ����
    public float baseBulletSpeed = 1.0f; // �⺻ ���� �ӵ�
    public float BulletSpeedIncrease = 0.1f; // �� ������ ���� �ӵ� ������

    // ���� ���׷��̵带 ó���ϴ� �Լ�
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // �� �������� ���� �ӵ��� ����
            baseBulletSpeed += BulletSpeedIncrease;
        }
    }

    // ���� ���� �ӵ� ��ȯ
    public float GetAttackSpeed()
    {
        return baseBulletSpeed;
    }
}
