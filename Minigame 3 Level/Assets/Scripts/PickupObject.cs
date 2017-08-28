using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
	public int Value = 1;

	public GameObject PickupExplosion;
	public AudioClip SFX;

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			GameManager.gm.Collect (Value);

			AudioSource.PlayClipAtPoint (SFX, transform.position);

			Instantiate (PickupExplosion, transform.position, Quaternion.identity);

			Destroy (gameObject);
		}
	}
}
