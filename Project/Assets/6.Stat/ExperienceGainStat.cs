using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceGainStat : MonoBehaviour
{
    public string ExperienceGain; // 스탯의 이름
    public int currentLevel = 1; // 현재 스탯 레벨
    public int maxLevel = 5; // 스탯의 최대 레벨
    public float baseExperienceGain = 1.0f; // 기본 경험치 획득량
    public float experienceGainIncrease = 0.1f; // 각 레벨당 경험치 획득량 증가량

    // 스탯 업그레이드를 처리하는 함수
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // 각 레벨마다 경험치 획득량을 증가
            baseExperienceGain += experienceGainIncrease;
        }
    }

    // 현재 경험치 획득량 반환
    public float GetExperienceGain()
    {
        return baseExperienceGain;
    }
}
