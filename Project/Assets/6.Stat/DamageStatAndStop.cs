using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageStatAndStop : MonoBehaviour
{
    public int maxPurchaseLimit = 5; // ���� ���� ���� Ƚ��
    public float basePower = 10.0f; // �⺻ �Ŀ�
    public float powerIncrease = -1; // ������ �Ŀ� ����
    public GameObject damageButton; // "Damage" ��ư�� ������ ����
    public YesButton value;
    void Start()
    {
        // "Damage" ��ư�� ã�Ƽ� ����
        //damageButton = transform.Find("Damage")?.GetComponent<Button>();
        UpdatePurchaseButtonInteractivity(); // ���� ���� ��ư�� Ȱ��ȭ ���� ������Ʈ
        value = FindObjectOfType<YesButton>();
    }

        // ���� ���׷��̵带 ó���ϴ� �Լ�
        public void UpdateStat()
        {
            if (value < maxPurchaseLimit)
            {

                basePower += (basePower * powerIncrease / 100);
                UpdatePurchaseButtonInteractivity();

                if (value >= maxPurchaseLimit)
                {
                    damageButton.SetActive(false); // ���� ���ѿ� ������ ��� ��ư ��Ȱ��ȭ
                }
            }
        }

        // ���� ���� ��ư�� Ȱ��ȭ ���θ� ������Ʈ�ϴ� �Լ�
        private void UpdatePurchaseButtonInteractivity()
        {
            if (damageButton != null)
            {
                if (value < maxPurchaseLimit) // ���� ������ ��� ��ư Ȱ��ȭ
                {
                    damageButton.SetActive(true);
                } // ���� ������ ��� ��ư Ȱ��ȭ
            }
        }

        // ���� ���� �Ŀ� ��ȯ
        public float GetStatPower()
        {
            return basePower;
        }
    }
