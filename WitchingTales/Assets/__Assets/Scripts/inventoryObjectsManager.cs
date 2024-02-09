using UnityEngine;
using System.IO;

public class inventoryObjectsManager : MonoBehaviour
{
    public InventoryData inventoryData;
    private string filePath;

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
