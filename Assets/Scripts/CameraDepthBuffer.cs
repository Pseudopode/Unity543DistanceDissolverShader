using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraDepthBuffer : MonoBehaviour
{
    void Start()
    {
        GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
    }
}