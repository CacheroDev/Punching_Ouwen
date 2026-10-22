
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    [Header("----- Audio Source-----")]
    [SerializeField] AudioSource SFXSource;

    [Header("------ Audio Clip------")]
    public AudioClip ha;
    public AudioClip punch_hit;
    public AudioClip sfx_CharTalk;
    public AudioClip woosh;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
