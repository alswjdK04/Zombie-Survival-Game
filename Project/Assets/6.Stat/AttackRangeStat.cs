using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRangeStat : MonoBehaviour
{
    public string AttackRange; // 스탯의 이름
    public int currentLevel = 1; // 현재 스탯 레벨
    public int maxLevel = 5; // 스탯의 최대 레벨
    public float baseAttackRange = 2.0f; // 기본 공격 범위
    public float attackRangeIncrease = 0.5f; // 각 레벨당 공격 범위 증가량

    // 스탯 업그레이드를 처리하는 함수
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // 각 레벨마다 공격 범위를 증가
            baseAttackRange += attackRangeIncrease;
        }
    }

    // 현재 공격 범위 반환
    public float GetAttackRange()
    {
        return baseAttackRange;
    }
}
