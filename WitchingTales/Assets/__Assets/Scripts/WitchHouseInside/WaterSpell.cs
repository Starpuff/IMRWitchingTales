using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterSpell : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject water;
    public AudioSource audioSource;

    public GameObject mix;

    public GameObject potion;

    public TextMeshProUGUI text;

    int count = 0;
    public void Click()
    {
        audioSource.mute = false;

        if (count <= 1)
        {
            water.SetActive(true);
            mix.SetActive(false);
            text.text = "Mix";
        }
        else if (count == 2)
        {
            water.SetActive(false);
            mix.SetActive(true);
            text.text = "Extract potion";
        }
        else
        {
            water.SetActive(false);
            mix.SetActive(false);
            potion.SetActive(true);
        }
        audioSource.Play();
        count++;
    }
}
