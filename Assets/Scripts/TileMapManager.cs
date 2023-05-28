using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapManager : MonoBehaviour
{
    [SerializeField] private GameObject normal;
    [SerializeField] private GameObject shadow;

    private void Awake()
    {
        DimensionManager.OnDimensionShift += DimensionManager_OnDimensionShift;
    }

    private void DimensionManager_OnDimensionShift(object sender, bool isNormalDimension)
    {
        normal.SetActive(isNormalDimension);
        shadow.SetActive(!isNormalDimension);
    }

    private void OnDestroy()
    {
        DimensionManager.OnDimensionShift -= DimensionManager_OnDimensionShift;
    }
}
