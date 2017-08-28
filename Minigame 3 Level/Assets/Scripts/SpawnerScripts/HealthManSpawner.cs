using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManSpawner : MonoBehaviour {

    public GameObject HealthMan;
    Vector3 randPlace;

    void Awake()
    {
        SpawnObject();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnObject()
    {
        for (int i = 0; i < 5; i++)
        {
            randPlace = new Vector3(Random.Range(-20, 20), 0.5f, Random.Range(-20, 20));

            GameObject objectClone = Instantiate(HealthMan, randPlace, Quaternion.identity);
            objectClone.transform.SetParent(transform); // stvara neprijatelja kao dijete objekta ispod kojeg je stvoreno
        }

    }
}
