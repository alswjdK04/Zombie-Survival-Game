using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseConfirmation : MonoBehaviour
{
    public GameObject StorePurchase;

    void Start()
    {
        // 초기에 확인 창을 숨깁니다.
        StorePurchase.SetActive(false);
    }

    public void ShowConfirmationPanel()
    {
        // 버튼을 누르면 확인 창을 보이도록 설정합니다.
        StorePurchase.SetActive(true);
    }

    public void ConfirmPurchase()
    {
        // 여기에 실제 구매 로직을 구현합니다.
        // 구매가 완료되면 이 함수가 호출되어야 합니다.

        // 구매가 완료되면 확인 창을 다시 숨깁니다.
        StorePurchase.SetActive(false);
    }

    public void CancelPurchase()
    {
        // 구매를 취소하면 확인 창을 닫습니다.
        StorePurchase.SetActive(false);
    }

}
