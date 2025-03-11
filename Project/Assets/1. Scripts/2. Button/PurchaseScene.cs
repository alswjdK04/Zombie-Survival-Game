using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PurchaseScene : MonoBehaviour
{
    public GameObject StorePurchase;
    public GameObject Store;

    public void PurchaseConfirmed()
    {
        // ���� Ȯ�� �� ���� Ȯ�� â ��Ȱ��ȭ
        StorePurchase.SetActive(false);

        // ���� â Ȱ��ȭ
        Store.SetActive(true);
    }

    public void PurchaseCanceled()
    {
        // ���� ��� �� ���� Ȯ�� â ��Ȱ��ȭ
        StorePurchase.SetActive(false);

        // ���� â Ȱ��ȭ
        Store.SetActive(true);
    }
}
