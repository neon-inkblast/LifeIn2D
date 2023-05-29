using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
