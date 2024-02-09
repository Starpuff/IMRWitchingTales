using UnityEngine;
using UnityEngine.UI;

public class KnockingDoorTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject cubeObject; // Reference to the cube GameObject

    private GameObject goOutsideCanvas; // Reference to the GameObject containing the canvas

    private void Start()
    {

        // Make sure the audio source is initially muted
        audioSource.mute = true;

        // Find the GameObject containing the canvas
        goOutsideCanvas = GameObject.FindGameObjectWithTag("GoOutsideCanvasTag");

        // Make the button invisible
        if (goOutsideCanvas != null)
        {
            Button goOutsideButton = goOutsideCanvas.transform.Find("Go outside").GetComponent<Button>();
            if (goOutsideButton != null)
            {
                goOutsideButton.gameObject.SetActive(false);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the capsule collider
        if (collision.collider.CompareTag("KnockingDoorTriggerTag"))
        {

            string parameter = PlayerPrefs.GetString("LoadMode");
            if (parameter == "1")
            {
                Destroy(cubeObject);
                return;
            }
            // Unmute the audio source
            audioSource.mute = false;

            // Play the audio
            audioSource.Play();

            // Destroy the cube object
            if (cubeObject != null)
            {
                Destroy(cubeObject);
            }

            // Make the button visible
            if (goOutsideCanvas != null)
            {
                Button goOutsideButton = goOutsideCanvas.transform.Find("Go outside").GetComponent<Button>();
                if (goOutsideButton != null)
                {
                    goOutsideButton.gameObject.SetActive(true);
                }
            }

            // You can also set a timer to mute the audio after a specific duration if needed
            Invoke("MuteAudio", audioSource.clip.length);
        }
    }

    // Uncomment the method below if you want to automatically mute the audio after a specific duration
    private void MuteAudio()
    {
        audioSource.mute = true;
    }
}
