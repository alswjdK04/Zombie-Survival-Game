using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeedStat : MonoBehaviour
{
    public string PlayerSpeed; // 스탯의 이름
    public int currentLevel = 1; // 현재 스탯 레벨
    public int maxLevel = 5; // 스탯의 최대 레벨
    public float basePlayerSpeed = 5.0f; // 기본 이동 속도
    public float PlayerSpeedIncrease = 1.0f; // 각 레벨당 이동 속도 증가량

    // 스탯 업그레이드를 처리하는 함수
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // 각 레벨마다 이동 속도를 증가
            basePlayerSpeed += PlayerSpeedIncrease;
        }
    }

    // 현재 이동 속도 반환
    public float GetMovementSpeed()
    {
        return basePlayerSpeed;
    }
}
