using System.Collections;
using UnityEngine;

public class VendorInteractor : MonoBehaviour
{
    public GameObject Vendor1stText;
    public GameObject Vendor2ndText;
    private bool wasPressedOnce = false;

    public void Click()
    {
        if (!wasPressedOnce)
        {
            wasPressedOnce = true;
            Vendor1stText.SetActive(true);
            StartCoroutine(HideVendorTextAfterDelay(Vendor1stText));
        }
        else
        {
            Vendor2ndText.SetActive(true);
            StartCoroutine(HideVendorTextAfterDelay(Vendor2ndText));
        }
    }

    private IEnumerator HideVendorTextAfterDelay(GameObject textObject)
    {
        yield return new WaitForSecondsRealtime(5);
        textObject.SetActive(false);
    }
}

    /*
    void Update()
    {
        float interactRange = 3f;
        if (Vector3.Distance(transform.position, Vendor.transform.position) <= interactRange)
        {
            Debug.Log("Interacting with the vendor!");
        }
    }
    */

