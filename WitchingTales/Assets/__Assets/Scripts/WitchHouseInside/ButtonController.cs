using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour
{
    public Button myButton; // Reference to your button
    public TextMeshProUGUI textAboveButton; // Reference to the TMP text above the button
    public Canvas canvas; // Reference to the canvas

    public Transform bedSpawnPoint; // Drag your bed object or an empty GameObject representing the spawn point here

    public GameObject playerPrefab; // Drag your XR player prefab here

    private void Start()
    {
        // Add a listener to the button's onClick event
        myButton.onClick.AddListener(OnButtonPressed);
        Debug.Log("ButtonController.cs: Button listener added");
    }

    public void OnButtonPressed()
    {
        Debug.Log("ButtonController.cs: Button pressed");
        // Check if there is TMP text above the button
        if (textAboveButton != null)
        {
            // Destroy the TMP text object above the button
            Destroy(textAboveButton.gameObject);
        }

        // Check if the button text is "Get out of bed"
        if (myButton.GetComponentInChildren<TextMeshProUGUI>().text == "Get out of bed")
        {
            // Implement the logic to spawn the player out of the bed
            Destroy(canvas.gameObject);
            SpawnPlayerOutOfBed();
        }
        else
        {
            myButton.GetComponentInChildren<TextMeshProUGUI>().text = "Get out of bed";
            RectTransform buttonRectTransform = myButton.GetComponent<RectTransform>();
            buttonRectTransform.SetParent(canvas.transform);
        }
    }

    void SpawnPlayerOutOfBed()
    {
        if (playerPrefab == null || bedSpawnPoint == null)
        {
            Debug.LogError("Player prefab or bed spawn point not assigned!");
            return;
        }

        // Spawn the player near the bed location
        Vector3 playerPosition = new Vector3(bedSpawnPoint.position.x - 2f, bedSpawnPoint.position.y + 0.5f, bedSpawnPoint.position.z);
        playerPrefab.transform.position = playerPosition;

        // Rotate the player to face the bed (adjust rotation as needed)
        playerPrefab.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }

}
