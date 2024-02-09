using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("WitchHouseInteriorScene");
        PlayerPrefs.SetString("LoadMode", "0");
    }
}
