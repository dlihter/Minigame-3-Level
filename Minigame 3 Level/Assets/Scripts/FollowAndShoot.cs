using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAndShoot : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1.0f;
    public float DistanceToKeep = 1.0f;

    private Transform _transform;

    void Awake()
    {
        _transform = GetComponent<Transform>();
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!Target)
        {
            Debug.Log("No target!");
            return;
        }

        _transform.LookAt(Target.position);

        float distance = Vector3.Distance(Target.position, _transform.position);

        if (distance >= DistanceToKeep)
        {
            _transform.position += _transform.forward * Speed * Time.deltaTime;
        }
   
	}

    void SetTarget(Transform newTarget)
    {
        Target = newTarget;
    }


}
