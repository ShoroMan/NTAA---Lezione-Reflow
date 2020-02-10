using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{
    public Camera secondCamera;
    public Material cameraMat2;
    // Start is called before the first frame update
    void Start()
    {
        if (secondCamera.targetTexture != null)
        {
            secondCamera.targetTexture.Release();
        }
        secondCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMat2.mainTexture = secondCamera.targetTexture;
    }
}
