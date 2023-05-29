using UnityEngine.SceneManagement;
using UnityEngine;

public class AudioManager : MonoPersistingSingleton<AudioManager>
{
    [SerializeField] private AudioSource bgAudio;

    [SerializeField] private AudioSource sfxAudio;

    protected override void Awake()
    {
        base.Awake();
    }


    public void PlayBg(AudioClip clip)
    {
        bgAudio.Play();
        bgAudio.clip = clip;
        bgAudio.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxAudio.PlayOneShot(clip);
    }
}
