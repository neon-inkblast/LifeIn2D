using UnityEngine;
using Cinemachine;
using TarodevController;

public class Switcher : MonoBehaviour
{
    public Color norm;
    public Color shadow;

    public SpriteRenderer spriteRenderer;

    PlayerController controller;

    void Awake()
    {
        controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            DimensionManager.Instance.ToggleDimension();
            if (controller.Grounded)
            {
                transform.position = transform.position + Vector3.up * 2.2f * (DimensionManager.Instance.IsNormal() ? 1 : -1);
            }
            controller.Flip();
            spriteRenderer.color = DimensionManager.Instance.IsNormal() ? norm : shadow;
        }
    }


}
