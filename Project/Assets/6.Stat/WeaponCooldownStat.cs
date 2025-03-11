using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCooldownStat : MonoBehaviour
{
    public string WeaponCooldown; // ������ �̸�
    public int currentLevel = 1; // ���� ���� ����
    public int maxLevel = 5; // ������ �ִ� ����
    public float baseCooldownTime = 2.0f; // �⺻ ���� ��Ÿ��
    public float cooldownTimeReduction = 0.2f; // �� ������ ���� ��Ÿ�� ���ҷ�

    // ���� ���׷��̵带 ó���ϴ� �Լ�
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // �� �������� ���� ��Ÿ���� ����
            baseCooldownTime -= cooldownTimeReduction;
        }
    }

    // ���� ���� ��Ÿ�� ��ȯ
    public float GetCooldownTime()
    {
        return baseCooldownTime;
    }
}
