using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("On trigger 2D: " + other.gameObject.name);
        if (other.gameObject.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            interactable.OnHit();
        }
    }
}
