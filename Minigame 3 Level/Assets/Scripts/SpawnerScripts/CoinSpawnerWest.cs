using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerWest : MonoBehaviour {

    public GameObject Coin;
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
        for (int i = 0; i < 10; i++)
        {
            randPlace = new Vector3(Random.Range(-30, -10), 0.5f, Random.Range(10, -10));

            GameObject objectClone = Instantiate(Coin, randPlace, Quaternion.identity);
            objectClone.transform.SetParent(transform); // stvara neprijatelja kao dijete objekta ispod kojeg je stvoreno
        }

    }
}
