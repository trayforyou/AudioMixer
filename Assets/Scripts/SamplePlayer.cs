using UnityEngine;
using UnityEngine.UI;

public class SamplePlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Button _button;

    private void OnEnable() =>
        _button.onClick.AddListener(Play);

    private void OnDisable() =>
        _button.onClick.RemoveListener(Play);
    
    public void Play() =>
        _audioSource.Play();
}