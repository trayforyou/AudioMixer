using UnityEngine;
using UnityEngine.Audio;

public class SwitcherSound : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioChannel;

    private int _minVolumeValue = -80;
    private int _maxVolumeValue = 0;

    public void ChangeActiveState(bool state)
    {
        if (state)
            _audioChannel.audioMixer.SetFloat(_audioChannel.name, _maxVolumeValue);
        else
            _audioChannel.audioMixer.SetFloat(_audioChannel.name, _minVolumeValue);
    }
}