using UnityEngine;
using UnityEngine.XR;
using System.Collections;


public class SetPlayerInBedScript : MonoBehaviour
{
    public GameObject holy;
    public GameObject apple;

    public Canvas cauldronCanvas;

    public Canvas spellbookCanvas;
    public GameObject playerPrefab; // Drag your XR player prefab here
    public Transform bedSpawnPoint; // Drag your bed object or an empty GameObject representing the spawn point here

    public AudioSource audioSource;
    public GameObject surface;
    public GameObject secondSurface;

    public GameObject potion;

    public GameObject line;
    public float playerHeightOffset = 1f;


    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        string parameter = PlayerPrefs.GetString("LoadMode");
        if (parameter == "1")
        {
            GameObject goOutsideCanvas = GameObject.FindGameObjectWithTag("GoOutsideCanvasTag");
            if (goOutsideCanvas != null)
            {
                Destroy(goOutsideCanvas);
            }
            if (line != null)
            {
                Destroy(line);
            }
            cauldronCanvas.gameObject.SetActive(false);
            surface.gameObject.SetActive(false);
            secondSurface.gameObject.SetActive(false);
            potion.gameObject.SetActive(false);
            audioSource.mute = true;
            return;
        }
        else
        {
            if (holy != null)
            {
                Destroy(holy);
            }
            if (apple != null)
            {
                Destroy(apple);
            }
            if (spellbookCanvas != null)
            {
                Destroy(spellbookCanvas);
            }
            if (cauldronCanvas != null)
            {
                Destroy(cauldronCanvas);
            }
            if (surface != null)
            {
                Destroy(surface);
            }
            if (secondSurface != null)
            {
                Destroy(secondSurface);
            }
            if (audioSource != null)
            {
                audioSource.mute = true;
            }
            if (potion != null)
            {
                Destroy(potion);
            }
        }

        if (playerPrefab == null || bedSpawnPoint == null)
        {
            Debug.LogError("Player prefab or bed spawn point not assigned!");
            return;
        }


        // Spawn the player at the bed location
        Vector3 playerPosition = new Vector3(bedSpawnPoint.position.x, bedSpawnPoint.position.y + playerHeightOffset, bedSpawnPoint.position.z);
        playerPrefab.transform.position = playerPosition;


        // Rotate the player to look at the roof (assuming roof is up in your scene)
        playerPrefab.transform.rotation = Quaternion.Euler(270f, 0f, 0f);
    }
}
