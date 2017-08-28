using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{	
		if(other.gameObject.CompareTag ("Player"))
		{
			HealthManager healthManager = other.GetComponent<HealthManager> ();

            healthManager.ApplyDamage (Mathf.Infinity);
          
        }
	}
}
