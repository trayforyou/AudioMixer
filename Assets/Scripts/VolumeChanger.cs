using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioChannel;
    [SerializeField] private Slider _slider;

    private void OnEnable() =>
        _slider.onValueChanged.AddListener(ChangeAllVolume);

    private void OnDisable() =>
        _slider.onValueChanged.RemoveListener(ChangeAllVolume);

    private void ChangeAllVolume(float volume) =>
        _audioChannel.audioMixer.SetFloat(_audioChannel.name, Mathf.Log10(volume) * 20);
}
