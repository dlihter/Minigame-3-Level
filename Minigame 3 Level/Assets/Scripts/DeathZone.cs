using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{	
		if(other.gameObject.CompareTag ("Player"))
		{
			HealthManager healthManager = other.GetComponent<HealthManager> ();

            //healthManager.ApplyDamage (Mathf.Infinity);
            healthManager.ApplyDamage(2);
        }
	}
}
