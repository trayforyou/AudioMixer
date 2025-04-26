using UnityEngine;

public class SamplePlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    
    public void Play() =>
        _audioSource.Play();
}