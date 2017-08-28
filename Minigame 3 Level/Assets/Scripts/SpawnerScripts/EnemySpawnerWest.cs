using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerWest : MonoBehaviour
{
    public GameObject CubeMan;
    public Transform TargetToChase;
    Vector3 randPlace;
    public int Enemies;

    void Awake()
    {
        SpawnObject();
    }

    // Use this for initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    private void SpawnObject()
    {
        for (int i = 0; i < Enemies; i++)
        {
            randPlace = new Vector3(Random.Range(-30, -10), 0.5f, Random.Range(10, -10));

            GameObject objectClone = Instantiate(CubeMan, randPlace, Quaternion.identity);
            objectClone.transform.SetParent(transform); // stvara neprijatelja kao dijete objekta ispod kojeg je stvoreno

            FollowTarget folowTarget = objectClone.GetComponent<FollowTarget>(); //stvorili smo varijablu klase FT i spremili ovo unutra

            if (folowTarget) // ukoliko postoji na objektu FT onda postavi koga da se lovi
            {
                folowTarget.SetTarget(TargetToChase);
            }
        }  

    }

}
