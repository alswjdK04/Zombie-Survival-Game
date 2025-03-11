using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletIncreaseStat : MonoBehaviour
{
    public string BulletIncrease; // ������ �̸�
    public int currentLevel = 1; // ���� ���� ����
    public int maxLevel = 3; // ������ �ִ� ����
    public int baseBulletCount = 1; // �⺻ �Ѿ� ����
    public int bulletCountIncrease = 1; // �� ������ �Ѿ� ���� ������

    // ���� ���׷��̵带 ó���ϴ� �Լ�
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // �� �������� �Ѿ� ������ ����
            baseBulletCount += bulletCountIncrease;
        }
    }

    // ���� �Ѿ� ���� ��ȯ
    public int GetBulletCount()
    {
        return baseBulletCount;
    }
}
