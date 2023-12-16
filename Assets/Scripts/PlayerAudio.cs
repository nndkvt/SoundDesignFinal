using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    private AudioSource _audio;
    private bool _isAudioPlaying = false;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (IsInput() && !_isAudioPlaying)
        {
            _audio.Play();
            _isAudioPlaying = true;
        }
        else if (!IsInput() && _isAudioPlaying)
        {
            _audio.Stop();
            _isAudioPlaying = false;
        }
    }

    private bool IsInput()
    {
        return (Input.GetAxisRaw("Horizontal") != 0.0f) || 
               (Input.GetAxisRaw("Vertical") != 0.0f);
    }
}
