using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public static class FFSParameterIDFetcher
{
    public static PARAMETER_ID GetParameterID(EventReference eventReference, string parameterName, Transform transform)
    {
        EventInstance instance = RuntimeManager.CreateInstance(eventReference);

        // Set the 3D attributes to the transform of the caller
        instance.set3DAttributes(RuntimeUtils.To3DAttributes(transform.position));

        // Get event description
        instance.getDescription(out EventDescription eventDescription);

        // Get parameter description
        eventDescription.getParameterDescriptionByName(parameterName, out PARAMETER_DESCRIPTION parameterDescription);

        // Release the instance as we only need the parameter description
        instance.release(); 

        return parameterDescription.id;
    }
}