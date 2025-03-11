using UnityEngine;
using UnityEngine.UI;

public class YesButton : MonoBehaviour
{
    public int purchaseCount = 0; // 구매 횟수를 저장할 변수
   

    public void OnPurchaseButtonClick()
    {
        purchaseCount++; // 구매 횟수 증가
    }
}
