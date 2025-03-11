using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerStat : MonoBehaviour
{
    public string Power; // 스탯의 이름
    public int currentLevel = 1; // 현재 스탯 레벨
    public int maxLevel = 5; // 스탯의 최대 레벨
    public float basePower = 10.0f; // 기본 파워
    public float powerIncreasePercentage = 10.0f; // 레벨당 파워 증가 퍼센트

    // 스탯 업그레이드를 처리하는 함수
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // 레벨당 파워 증가 퍼센트를 적용하여 파워를 업데이트
            basePower += (basePower * powerIncreasePercentage / 100);
        }
    }

    // 현재 스탯 파워 반환
    public float GetStatPower()
    {
        return basePower;
    }
}


