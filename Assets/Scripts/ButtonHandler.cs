using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void OnStartClick()
    {
        LevelManager.Instance.NextLevel();
    }
}
