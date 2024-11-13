using UnityEngine;

public class PUQIMAY : MonoBehaviour
{
    public GameObject kacangObject;
    public GameObject minyakObject;
    public GameObject nasiObject;
    public GameObject sayurObject;
    
    private void Start()
    {
        if (Inventory.Instance.HasItem(Item.ItemType.Kacang))
        {
            kacangObject.SetActive(true); 
            Debug.Log("Kacang tersedia di scene ini dengan jumlah: " + Inventory.Instance.GetItemAmount(Item.ItemType.Kacang));
        }
        else
        {
            kacangObject.SetActive(false); 
        }


        if (Inventory.Instance.HasItem(Item.ItemType.Sayur))
        {
            sayurObject.SetActive(true); 
            Debug.Log("Kacang tersedia di scene ini dengan jumlah: " + Inventory.Instance.GetItemAmount(Item.ItemType.Kacang));
        }
        else
        {
            sayurObject.SetActive(false); 
        }


        if (Inventory.Instance.HasItem(Item.ItemType.Nasi))
        {
            nasiObject.SetActive(true); 
            Debug.Log("Kacang tersedia di scene ini dengan jumlah: " + Inventory.Instance.GetItemAmount(Item.ItemType.Kacang));
        }
        else
        {
            nasiObject.SetActive(false); 
        }
        

        if (Inventory.Instance.HasItem(Item.ItemType.Minyak))
        {
            minyakObject.SetActive(true); 
            Debug.Log("Kacang tersedia di scene ini dengan jumlah: " + Inventory.Instance.GetItemAmount(Item.ItemType.Kacang));
        }
        else
        {
            minyakObject.SetActive(false); 
        }
    }
}
