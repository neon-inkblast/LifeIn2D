using UnityEngine;
public class Goal : MonoBehaviour, IInteractable
{
    [SerializeField] private ParticleSystem winParticles;
    [SerializeField] private AudioClip onHitSFX;

    [SerializeField] private float nextLevelTime = 2f;

    private void Awake()
    {
        winParticles.Stop();
    }
    public void OnHit()
    {
        Debug.Log("HIT FLAG");
        winParticles.Play();
        AudioManager.Instance.PlaySFX(onHitSFX);
        Invoke("StartNextLevel", );
        GetComponent<Collider2D>().enabled = false;
    }

    private void StartNextLevel()
    {
        LevelManager.Instance.NextLevel();
    }
}
