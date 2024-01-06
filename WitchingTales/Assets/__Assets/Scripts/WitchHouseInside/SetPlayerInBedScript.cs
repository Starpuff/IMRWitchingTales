using UnityEngine;
using UnityEngine.XR;
using System.Collections;


public class SetPlayerInBedScript : MonoBehaviour
{
    public GameObject playerPrefab; // Drag your XR player prefab here
    public Transform bedSpawnPoint; // Drag your bed object or an empty GameObject representing the spawn point here

    public float playerHeightOffset = 1f;

    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
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
