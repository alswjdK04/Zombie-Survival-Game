using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseConfirmation : MonoBehaviour
{
    public GameObject StorePurchase;

    void Start()
    {
        // �ʱ⿡ Ȯ�� â�� ����ϴ�.
        StorePurchase.SetActive(false);
    }

    public void ShowConfirmationPanel()
    {
        // ��ư�� ������ Ȯ�� â�� ���̵��� �����մϴ�.
        StorePurchase.SetActive(true);
    }

    public void ConfirmPurchase()
    {
        // ���⿡ ���� ���� ������ �����մϴ�.
        // ���Ű� �Ϸ�Ǹ� �� �Լ��� ȣ��Ǿ�� �մϴ�.

        // ���Ű� �Ϸ�Ǹ� Ȯ�� â�� �ٽ� ����ϴ�.
        StorePurchase.SetActive(false);
    }

    public void CancelPurchase()
    {
        // ���Ÿ� ����ϸ� Ȯ�� â�� �ݽ��ϴ�.
        StorePurchase.SetActive(false);
    }

}
