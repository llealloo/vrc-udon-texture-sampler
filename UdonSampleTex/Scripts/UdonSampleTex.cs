
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class UdonSampleTex : UdonSharpBehaviour
{
	[SerializeField]
    private Texture2D texture2D;

    public Color[] textureData;

    void Start()
    {
        
    }

    void OnPostRender()
    {
        texture2D.ReadPixels(new Rect(0, 0, texture2D.width, texture2D.height), 0, 0, false);
        textureData = texture2D.GetPixels();
    }
}
