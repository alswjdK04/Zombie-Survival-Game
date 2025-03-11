using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeedStat : MonoBehaviour
{
    public string BulletSpeed; // 스탯의 이름
    public int currentLevel = 1; // 현재 스탯 레벨
    public int maxLevel = 5; // 스탯의 최대 레벨
    public float baseBulletSpeed = 1.0f; // 기본 공격 속도
    public float BulletSpeedIncrease = 0.1f; // 각 레벨당 공격 속도 증가량

    // 스탯 업그레이드를 처리하는 함수
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // 각 레벨마다 공격 속도를 증가
            baseBulletSpeed += BulletSpeedIncrease;
        }
    }

    // 현재 공격 속도 반환
    public float GetAttackSpeed()
    {
        return baseBulletSpeed;
    }
}
