using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("There's more than one singleton of this type! " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this as T;
    }
}

public abstract class MonoPersistingSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("There's more than one singleton of this type! " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        Instance = this as T;
    }
}