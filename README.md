# FMOD-Unity parameter-ID fetcher
Gets the parameter ID of a given event. Useful if you want to optimize performance by setting parameters by id.

# Example
```cs
void Awake()
{
    // Material
    ParamID = FFSParameterIDFetcher.GetParameterID(FootstepsEventPath, "Material", transform);
}

private void LocalPlayFootstepSound(int _F_MaterialValue)
{
    EventInstance Footstep = FMODUnity.RuntimeManager.CreateInstance(FootstepsEventPath);
    RuntimeManager.AttachInstanceToGameObject(Footstep, transform);
    Footstep.setParameterByID(ParamID, _F_MaterialValue);
    Footstep.start();
    Footstep.release();
}
```
