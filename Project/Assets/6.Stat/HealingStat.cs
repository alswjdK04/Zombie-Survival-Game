using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingStat : MonoBehaviour
{
    public string Healing; // 스탯의 이름
    public int currentLevel = 1; // 현재 스탯 레벨
    public int maxLevel = 5; // 스탯의 최대 레벨
    public float baseHealing = 5.0f; // 기본 회복량
    public float healingIncrease = 0.1f; // 각 레벨당 회복량 증가량

    // 스탯 업그레이드를 처리하는 함수
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // 각 레벨마다 회복량을 증가
            baseHealing += healingIncrease;
        }
    }

    // 현재 회복량 반환
    public float GetHealingRate()
    {
        return baseHealing;
    }
}
