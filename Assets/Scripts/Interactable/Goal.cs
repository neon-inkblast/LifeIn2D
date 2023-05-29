using UnityEngine;
public class Goal : MonoBehaviour, IInteractable
{
    [SerializeField] private ParticleSystem winParticles;
    [SerializeField] private AudioClip onHitSFX;

    private void Awake()
    {
        winParticles.Stop();
    }
    public void OnHit()
    {
        Debug.Log("HIT FLAG");
        winParticles.Play();
        AudioManager.Instance.PlaySFX(onHitSFX);
        Invoke("StartNextLevel", 1f);
        GetComponent<Collider2D>().enabled = false;
    }

    private void StartNextLevel()
    {
        LevelManager.Instance.NextLevel();
    }
}
