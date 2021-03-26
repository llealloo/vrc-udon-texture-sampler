
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System;

public class PixelLight : UdonSharpBehaviour
{

	[SerializeField]
	private Light light;
	[SerializeField]
	private UdonBehaviour textureSampler;
	[SerializeField]
	private String textureVar;
	[SerializeField]
	private int pixel;


    void Start()
    {
        
    }

    void Update()
    {
    	Color[] textureData = (Color[])textureSampler.GetProgramVariable(textureVar);
    	Debug.Log( textureData.Length );
    	if( textureData.Length > 0 )
    	{
    		light.color = textureData[pixel];
    		//light.intensity = textureData[pixel].grayscale;
    	}

    }
}