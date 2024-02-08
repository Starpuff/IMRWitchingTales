using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryObjectsManager : MonoBehaviour
{
    public List<GameObject> inventoryObjects;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        inventoryObjects = new List<GameObject>();
        count = 0;
    }

    private void Update()
    {
        inventoryObjects.Clear(); 
        foreach (Transform child in transform) 
        {
            inventoryObjects.Add(child.gameObject);
        }
    }
}
