using UnityEngine;

public class AudioComtroller : MonoBehaviour
{
    public void OnOfAudio(AudioSource audioSource)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }
    }
}
