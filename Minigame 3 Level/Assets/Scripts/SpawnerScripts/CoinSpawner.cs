using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    public GameObject Coin;
    Vector3 randPlace;
    public int coinNumber;

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
        for (int i = 0; i < coinNumber; i++)
        {
            randPlace = new Vector3(Random.Range(-20, 20), 0.5f, Random.Range(-20, 20));

            GameObject objectClone = Instantiate(Coin, randPlace, Quaternion.identity);
            objectClone.transform.SetParent(transform); // stvara neprijatelja kao dijete objekta ispod kojeg je stvoreno
        }

    }
}
