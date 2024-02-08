using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{
    public inventoryObjectsManager inventoryObjectsManager;
    public Sprite defaultInventorySlotSprite;

    void Start()
    {
        if (inventoryObjectsManager == null)
        {
            Debug.LogError("InventoryObjectsManager reference is missing in InventoryManager.");
            return;
        }
        UpdateInventoryUI(); // Call the UpdateInventoryUI method instead of Update
    }

    // UpdateInventoryUI method instead of Update
    public void UpdateInventoryUI()
    {
        /*
        // Ensure that the inventoryObjectsManager has been updated with its children
        inventoryObjectsManager.UpdateInvObjManager();

        // Get the GameObject to which this script is attached (InventoryUI)
        GameObject InventoryUI = gameObject;

        foreach (Transform child in InventoryUI.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (GameObject inventoryObject in inventoryObjectsManager.inventoryObjects)
        {
            // Create a new UI image object for the inventory object
            GameObject inventorySlot = new GameObject("InventorySlot", typeof(Image));
            inventorySlot.transform.SetParent(InventoryUI.transform, false); // Set parent and position within the inventory UI

            Image image = inventorySlot.GetComponent<Image>();

            // Check if the inventory object has a SpriteRenderer component
            SpriteRenderer spriteRenderer = inventoryObject.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                // Set the sprite of the inventory slot to represent the inventory object
                image.sprite = spriteRenderer.sprite;
            }
            else
            {
                // If the inventory object doesn't have a SpriteRenderer, use the default sprite
                image.sprite = defaultInventorySlotSprite;
                Debug.LogWarning("Inventory object '" + inventoryObject.name + "' does not have a SpriteRenderer component.");
            }

            // If the inventory object is named "Holly", use its name as the inventory slot name
            if (inventoryObject.name == "Holly")
            {
                inventorySlot.name = inventoryObject.name;
            }
            
        } */
    }
}
