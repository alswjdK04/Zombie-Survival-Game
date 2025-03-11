using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageStatAndStop : MonoBehaviour
{
    public int maxPurchaseLimit = 5; // 스탯 구매 제한 횟수
    public float basePower = 10.0f; // 기본 파워
    public float powerIncrease = -1; // 레벨당 파워 감소
    public GameObject damageButton; // "Damage" 버튼을 저장할 변수
    public YesButton value;
    void Start()
    {
        // "Damage" 버튼을 찾아서 저장
        //damageButton = transform.Find("Damage")?.GetComponent<Button>();
        UpdatePurchaseButtonInteractivity(); // 스탯 구매 버튼의 활성화 여부 업데이트
        value = FindObjectOfType<YesButton>();
    }

        // 스탯 업그레이드를 처리하는 함수
        public void UpdateStat()
        {
            if (value < maxPurchaseLimit)
            {

                basePower += (basePower * powerIncrease / 100);
                UpdatePurchaseButtonInteractivity();

                if (value >= maxPurchaseLimit)
                {
                    damageButton.SetActive(false); // 구매 제한에 도달한 경우 버튼 비활성화
                }
            }
        }

        // 스탯 구매 버튼의 활성화 여부를 업데이트하는 함수
        private void UpdatePurchaseButtonInteractivity()
        {
            if (damageButton != null)
            {
                if (value < maxPurchaseLimit) // 구매 가능한 경우 버튼 활성화
                {
                    damageButton.SetActive(true);
                } // 구매 가능한 경우 버튼 활성화
            }
        }

        // 현재 스탯 파워 반환
        public float GetStatPower()
        {
            return basePower;
        }
    }
