using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletIncreaseStat : MonoBehaviour
{
    public string BulletIncrease; // 스탯의 이름
    public int currentLevel = 1; // 현재 스탯 레벨
    public int maxLevel = 3; // 스탯의 최대 레벨
    public int baseBulletCount = 1; // 기본 총알 개수
    public int bulletCountIncrease = 1; // 각 레벨당 총알 개수 증가량

    // 스탯 업그레이드를 처리하는 함수
    public void UpdateStat()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // 각 레벨마다 총알 개수를 증가
            baseBulletCount += bulletCountIncrease;
        }
    }

    // 현재 총알 개수 반환
    public int GetBulletCount()
    {
        return baseBulletCount;
    }
}
