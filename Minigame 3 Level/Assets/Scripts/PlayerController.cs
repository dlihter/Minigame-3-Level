using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10.0f;
    public float jumpForce = 50.0f;
    public LayerMask groundLayer;

    private Rigidbody _rb;
    private float _moveHorizontal;
    private float _moveVertical;
    private float _jumpForce;


	// Use this for initialization
	void Start ()
    {
        _rb = GetComponent<Rigidbody>();
	}
	
    void Update()
    {
        _moveHorizontal = Input.GetAxis("Horizontal");
        _moveVertical = Input.GetAxis("Vertical");
    }

	// Update is called once per frame
	void FixedUpdate ()
    {
        Move();
	}

    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            _jumpForce = jumpForce;
        }
        else
        {
            _jumpForce = 0.0f;
        }

        Vector3 movement = new Vector3(_moveHorizontal, _jumpForce, _moveVertical);
        _rb.AddForce(movement * Speed, ForceMode.Force);
    }

    private bool IsGrounded()
    {
        if (Physics.Raycast(transform.position, Vector3.down, 1.0f, groundLayer.value))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
