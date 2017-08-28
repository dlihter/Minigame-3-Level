using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectDestructor : MonoBehaviour
{
	public float Time = 1.0f;

	void Awake ()
	{
		Invoke ("DestroyObject", Time);
	}

	void DestroyObject ()
	{
		Destroy (gameObject);
	}
}
