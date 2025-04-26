using UnityEngine;
using UnityEngine.Audio;

public class SwitcherSound : MonoBehaviour
{
    const string MasterVolume = "MasterVolume";
    const string ButtonVolume = "ButtonVolume";
    const string MusicVolume = "MusicVolume";

    [SerializeField] private AudioMixerGroup _masterGroup;

    private int _minVolumeValue = -80;
    private int _maxVolumeValue = 0;

    public void ChangeActiveState(bool state)
    {
        if (state)
            _masterGroup.audioMixer.SetFloat(MasterVolume, _maxVolumeValue);
        else
            _masterGroup.audioMixer.SetFloat(MasterVolume, _minVolumeValue);
    }

    public void ChangeAllVolume(float volume) =>
        _masterGroup.audioMixer.SetFloat(MasterVolume, Mathf.Log10(volume) * 20);
    
    public void ChangeButtonVolume(float volume) =>
        _masterGroup.audioMixer.SetFloat(ButtonVolume, Mathf.Log10(volume) * 20);

    public void ChangeMusicVolume(float volume) =>
        _masterGroup.audioMixer.SetFloat(MusicVolume, Mathf.Log10(volume) * 20);
}