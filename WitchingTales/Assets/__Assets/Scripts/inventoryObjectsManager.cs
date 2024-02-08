using UnityEngine;

public class inventoryObjectsManager : MonoBehaviour
{
    public InventoryData inventoryData;

    void Start()
    {
        UpdateInvObjManager();
    }

    public void UpdateInvObjManager()
    {
        if (inventoryData != null)
            inventoryData.inventoryObjects.Clear();

        foreach (Transform child in transform)
        {
            inventoryData.inventoryObjects.Add(child.gameObject);
        }
    }
}
