using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapManager : MonoBehaviour
{
    [SerializeField] private Tilemap normal;
    [SerializeField] private Tilemap shadow;

    private void Awake()
    {
        DimensionManager.OnDimensionShift += DimensionManager_OnDimensionShift;
    }

    private void DimensionManager_OnDimensionShift(object sender, bool isNormalDimension)
    {
        normal.gameObject.SetActive(isNormalDimension);
        shadow.gameObject.SetActive(!isNormalDimension);
    }

    private void OnDestroy()
    {

    }
}
