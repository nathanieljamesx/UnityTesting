using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowResRenderer : MonoBehaviour
{
    public Camera[] allCameras;
    private RenderTexture[] allRendTex;
    private int yRes = 175;

    // Start is called before the first frame update
    void Start()
    {
        SetupRenderTextures();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(x: 0, y: 0, Screen.width, Screen.height),allRendTex[0],ScaleMode.StretchToFill);

    }    

    void SetupRenderTextures()
    {
        allRendTex = new RenderTexture[allCameras.Length];

        int ratio = Screen.height / yRes;
        int newScreenWidth = Screen.width / ratio;
        int newScreenHeight = Screen.height / ratio;

        for (int i = 0; i < allRendTex.Length; i++)
        {
            allRendTex[i] = new RenderTexture(newScreenWidth, newScreenHeight, 0, RenderTextureFormat.ARGB32);

            allRendTex[i].antiAliasing = 1;
            allRendTex[i].filterMode = FilterMode.Point;
            allRendTex[i].isPowerOfTwo = false;

            allCameras[i].targetTexture = allRendTex[i];

        }

    }
}
