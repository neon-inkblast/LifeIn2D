using System;

public class DimensionManager : MonoSingleton<DimensionManager>
{
    public static EventHandler<bool> OnDimensionShift;
    private bool isNormal = true;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        OnDimensionShift?.Invoke(this, isNormal);
    }

    public void ToggleDimension()
    {
        isNormal = !isNormal;
        OnDimensionShift?.Invoke(this, isNormal);
    }

    public bool IsNormal()
    {
        return isNormal;
    }

    public bool IsShadow()
    {
        return !isNormal;
    }
}
