using UnityEngine;
using UnityEngine.UI;

public class KnockingDoorTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        // Make sure the audio source is initially muted
        audioSource.mute = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the capsule collider
        if (collision.collider.CompareTag("KnockingDoorTriggerTag"))
        {
            // Unmute the audio source
            audioSource.mute = false;

            // Play the audio
            audioSource.Play();

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
