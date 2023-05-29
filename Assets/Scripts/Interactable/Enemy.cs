using UnityEngine;
public class Enemy : MonoBehaviour, IInteractable
{
    [SerializeField]
    private AudioClip onHitSFX;

    public void OnHit()
    {
        Debug.Log("HIT ENEMY");
        AudioManager.Instance.PlaySFX(onHitSFX);
        LevelManager.Instance.RestartLevel();
    }
}
