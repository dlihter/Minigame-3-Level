using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
	public float force = 100f;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(SpawnBullet());
	}
	

    private IEnumerator SpawnBullet()
    {
        while (true)
        {
            GameObject bulletClone = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bulletClone.transform.SetParent(transform);
			bulletClone.GetComponent<Rigidbody>().AddForce(Vector3.forward * force * Time.deltaTime, ForceMode.Impulse);
            yield return new WaitForSeconds(2f);
        }
    }
}
