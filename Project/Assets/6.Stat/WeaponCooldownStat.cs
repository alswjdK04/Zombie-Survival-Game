using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCooldownStat : MonoBehaviour
{
    public string WeaponCooldown; // 스탯의 이름
    public int currentLevel = 1; // 현재 스탯 레벨
    public int maxLevel = 5; // 스탯의 최대 레벨
    public float baseCooldownTime = 2.0f; // 기본 무기 쿨타임
    public float cooldownTimeReduction = 0.2f; // 각 레벨당 무기 쿨타임 감소량

    // 스탯 업그레이드를 처리하는 함수
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // 각 레벨마다 무기 쿨타임을 감소
            baseCooldownTime -= cooldownTimeReduction;
        }
    }

    // 현재 무기 쿨타임 반환
    public float GetCooldownTime()
    {
        return baseCooldownTime;
    }
}
