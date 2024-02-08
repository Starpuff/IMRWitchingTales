using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Inventory Data", menuName = "Inventory/Inventory Data")]
public class InventoryData : ScriptableObject
{
    public List<GameObject> inventoryObjects = new List<GameObject>();
}
