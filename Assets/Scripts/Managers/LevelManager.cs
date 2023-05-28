using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoPersistingSingleton<LevelManager>
{
    protected override void Awake()
    {
        base.Awake();
    }

    public void NextLevel()
    {
        var currentIndex = SceneManager.GetActiveScene().buildIndex;
        int nextIndex = currentIndex + 1;
        if (nextIndex >= SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(nextIndex);
        }

    }

    public void RestartLevel()
    {
        var currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex);
    }
}
