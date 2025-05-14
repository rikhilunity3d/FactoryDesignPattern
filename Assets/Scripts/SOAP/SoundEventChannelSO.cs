using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "CustomEvents/Sound Event Channel")]
public class SoundEventChannelSO : ScriptableObject
{
    public UnityAction<AudioClip> OnSoundRequested;

    public void RaiseEvent(AudioClip clip)
    {
        OnSoundRequested?.Invoke(clip);
    }
}

