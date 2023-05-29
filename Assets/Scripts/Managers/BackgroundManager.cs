using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer srenderer;
    [SerializeField] private Sprite normal;
    [SerializeField] private Sprite shadow;

    private void Awake()
    {
        DimensionManager.OnDimensionShift += DimensionManager_OnDimensionShift;
    }

    private void DimensionManager_OnDimensionShift(object sender, bool isNormalDimension)
    {
        srenderer.sprite = isNormalDimension ? normal : shadow;
    }

    private void OnDestroy()
    {
        DimensionManager.OnDimensionShift -= DimensionManager_OnDimensionShift;
    }
}
