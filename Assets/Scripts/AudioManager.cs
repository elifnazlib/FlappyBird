using UnityEngine;

// This class is used to manage sound effects in the game.

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] clips;

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySFX(int index)
    {
        audioSource.PlayOneShot(clips[index], 1f);
    }

}
