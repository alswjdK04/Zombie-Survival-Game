using UnityEngine;
using UnityEngine.UI;

public class YesButton : MonoBehaviour
{
    public int purchaseCount = 0; // ���� Ƚ���� ������ ����
   

    public void OnPurchaseButtonClick()
    {
        purchaseCount++; // ���� Ƚ�� ����
    }
}
