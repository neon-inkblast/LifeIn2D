using UnityEngine;
using Cinemachine;
using TarodevController;

public class Switcher : MonoBehaviour
{
    public Color norm;
    public Color shadow;


    public SpriteRenderer spriteRenderer;

    [SerializeField] private float shiftAmount = 2.56f;
    [SerializeField] private AudioClip onShiftSFX;
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
            var isNormal = DimensionManager.Instance.IsNormal();
            if (controller.Grounded)
            {
                transform.position = transform.position + Vector3.up * 2f * shiftAmount * (isNormal ? 1 : -1);
            }
            controller.Flip();
            AudioManager.Instance.PlaySFX(onShiftSFX);
            spriteRenderer.color = isNormal ? norm : shadow;
            spriteRenderer.flipY = !isNormal;
        }
    }


}
