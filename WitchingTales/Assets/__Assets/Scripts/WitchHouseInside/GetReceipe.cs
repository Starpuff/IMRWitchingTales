using System.Collections;
using UnityEngine;

public class GetReceipe : MonoBehaviour
{
    public GameObject Text;
    public Canvas cauldronCanvas;

    public void Click()
    {
        Text.SetActive(true);
        cauldronCanvas.gameObject.SetActive(true);
        StartCoroutine(HideTextAfterDelay(Text));
    }

    private IEnumerator HideTextAfterDelay(GameObject textObject)
    {
        yield return new WaitForSecondsRealtime(15);
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

