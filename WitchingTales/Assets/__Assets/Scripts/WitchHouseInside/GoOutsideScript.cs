using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GoOutsideScript : MonoBehaviour
{

    public Button myButton;

    // Start is called before the first frame update
    void Start()
    {
        myButton.onClick.AddListener(OnButtonPressed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed()
    {
        SceneManager.LoadScene("TownScene");
    }
}
