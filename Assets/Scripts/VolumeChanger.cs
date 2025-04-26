using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioChannel;

    public void ChangeAllVolume(float volume) =>
        _audioChannel.audioMixer.SetFloat(_audioChannel.name, Mathf.Log10(volume) * 20);
}
