using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuesterInteraction : MonoBehaviour
{
    public GameObject VendorText;
    public void Click()
    {
        VendorText.SetActive(true);
        StartCoroutine(HideVendorTextAfterDelay(VendorText));
    }

    private IEnumerator HideVendorTextAfterDelay(GameObject textObject)
    {
        yield return new WaitForSecondsRealtime(10);
        textObject.SetActive(false);
    }
}
