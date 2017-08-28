using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPillarSpawner : MonoBehaviour
{
    public GameObject DeathPillar;
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
            randPlace = new Vector3(Random.Range(-15, 15), 2.5f, Random.Range(-15, 15));

            GameObject objectClone = Instantiate(DeathPillar, randPlace, Quaternion.identity);
            objectClone.transform.SetParent(transform); // stvara neprijatelja kao dijete objekta ispod kojeg je stvoreno
        }

    }
}
