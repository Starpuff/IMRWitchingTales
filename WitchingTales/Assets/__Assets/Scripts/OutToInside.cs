using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutToInside : MonoBehaviour
{

    public GameObject inventoryData;
    public GameObject text;
    public void StartButton()
    {
        Transform parentTransform = inventoryData.transform;

        // Count the number of children
        int childCount = parentTransform.childCount;

        if (childCount == 2)
        {
            SceneManager.LoadScene("WitchHouseInteriorScene");
            PlayerPrefs.SetString("LoadMode", "1");
        }

        else
        {
            text.SetActive(true);
            StartCoroutine(HideVendorTextAfterDelay(text));
        }
    }

    private IEnumerator HideVendorTextAfterDelay(GameObject textObject)
    {
        yield return new WaitForSecondsRealtime(5);
        textObject.SetActive(false);
    }
}
