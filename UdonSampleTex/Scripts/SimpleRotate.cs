
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SimpleRotate : UdonSharpBehaviour
{

	[SerializeField]
	private float rotateSpeed;

    void Start()
    {
        
    }

    void Update()
    {
    	transform.Rotate(0f, rotateSpeed, 0f, Space.Self);

    }
}
