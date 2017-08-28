using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeOnOff : MonoBehaviour
{  
	// Use this for initialization
	void Start ()
    {
        GameObject.FindGameObjectWithTag("Bridge").GetComponent<Renderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
   

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Bridge").GetComponent<Renderer>().enabled = true;
            GameObject.FindGameObjectWithTag("WestMagicWall").GetComponent<Collider>().isTrigger = true;
            GameObject.FindGameObjectWithTag("EastMagicWall").GetComponent<Collider>().isTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Bridge").GetComponent<Renderer>().enabled = false;
            GameObject.FindGameObjectWithTag("WestMagicWall").GetComponent<Collider>().isTrigger = false;
            GameObject.FindGameObjectWithTag("EastMagicWall").GetComponent<Collider>().isTrigger = false;
        }
    }
}
