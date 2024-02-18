using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(UniversalAdditionalCameraData))]
public class CameraCopyManager : MonoBehaviour
{
    private UniversalAdditionalCameraData cameraData;

    private void Start()
    {
        cameraData = GetComponent<UniversalAdditionalCameraData>();
    }
    public void AddCopy(GameObject copy)
    {
        cameraData.cameraStack.Add(copy.GetComponentInChildren<Camera>());
    }
}
