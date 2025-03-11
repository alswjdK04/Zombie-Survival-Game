using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRangeStat : MonoBehaviour
{
    public string AttackRange; // ������ �̸�
    public int currentLevel = 1; // ���� ���� ����
    public int maxLevel = 5; // ������ �ִ� ����
    public float baseAttackRange = 2.0f; // �⺻ ���� ����
    public float attackRangeIncrease = 0.5f; // �� ������ ���� ���� ������

    // ���� ���׷��̵带 ó���ϴ� �Լ�
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // �� �������� ���� ������ ����
            baseAttackRange += attackRangeIncrease;
        }
    }

    // ���� ���� ���� ��ȯ
    public float GetAttackRange()
    {
        return baseAttackRange;
    }
}
