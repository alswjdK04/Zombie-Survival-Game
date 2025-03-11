using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PurchaseScene : MonoBehaviour
{
    public GameObject StorePurchase;
    public GameObject Store;

    public void PurchaseConfirmed()
    {
        // 구매 확인 후 구매 확인 창 비활성화
        StorePurchase.SetActive(false);

        // 상점 창 활성화
        Store.SetActive(true);
    }

    public void PurchaseCanceled()
    {
        // 구매 취소 시 구매 확인 창 비활성화
        StorePurchase.SetActive(false);

        // 상점 창 활성화
        Store.SetActive(true);
    }
}
