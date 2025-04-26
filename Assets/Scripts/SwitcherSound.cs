using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SwitcherSound : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioChannel;
    [SerializeField] private Toggle _toggle;

    private int _minVolumeValue = -80;
    private int _maxVolumeValue = 0;

    private void OnEnable() =>
        _toggle.onValueChanged.AddListener(ChangeActiveState);

    private void OnDisable() =>
        _toggle.onValueChanged.RemoveListener(ChangeActiveState);

    public void ChangeActiveState(bool state)
    {
        if (state)
            _audioChannel.audioMixer.SetFloat(_audioChannel.name, _maxVolumeValue);
        else
            _audioChannel.audioMixer.SetFloat(_audioChannel.name, _minVolumeValue);
    }
}