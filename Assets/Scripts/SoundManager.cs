using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : GenericSingleton<SoundManager>
{
    [SerializeField] private SoundEventChannelSO soundEvent;
    [SerializeField] private AudioSource audioSource;

    private void OnEnable()
    {
        soundEvent.OnSoundRequested += PlaySound;
    }

    private void OnDisable()
    {
        soundEvent.OnSoundRequested -= PlaySound;
    }

    private void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}