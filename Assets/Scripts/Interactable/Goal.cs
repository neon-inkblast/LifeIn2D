using UnityEngine;
public class Goal : MonoBehaviour, IInteractable
{
    [SerializeField]
    private ParticleSystem winParticles;

    private void Awake()
    {
        winParticles.Stop();
    }
    public void OnHit()
    {
        Debug.Log("HIT FLAG");
        winParticles.Play();
        Invoke("StartNextLevel", 5f);
    }

    private void StartNextLevel()
    {
        LevelManager.Instance.NextLevel();
    }
}
