using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        Kacang,
        Minyak,
        Nasi,
        Sayur
    }

    public ItemType itemType;
    public int amount;

    // Mengatur tipe dan jumlah item
    public Item(ItemType itemType, int amount)
    {
        this.itemType = itemType;
        this.amount = amount;
    }
}
