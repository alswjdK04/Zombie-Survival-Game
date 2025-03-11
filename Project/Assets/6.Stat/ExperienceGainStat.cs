using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceGainStat : MonoBehaviour
{
    public string ExperienceGain; // ������ �̸�
    public int currentLevel = 1; // ���� ���� ����
    public int maxLevel = 5; // ������ �ִ� ����
    public float baseExperienceGain = 1.0f; // �⺻ ����ġ ȹ�淮
    public float experienceGainIncrease = 0.1f; // �� ������ ����ġ ȹ�淮 ������

    // ���� ���׷��̵带 ó���ϴ� �Լ�
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // �� �������� ����ġ ȹ�淮�� ����
            baseExperienceGain += experienceGainIncrease;
        }
    }

    // ���� ����ġ ȹ�淮 ��ȯ
    public float GetExperienceGain()
    {
        return baseExperienceGain;
    }
}
