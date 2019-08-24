using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private GameObject Player;

	[SerializeField]
	private Camera m_camera;

	private Rigidbody _rigidbody;

	bool isForward;
	bool isBack;
	bool isRight;
	bool isLeft;
	bool isJump;
	bool isRotate_R;
	bool isRotate_L;

	Vector3 offsetPos;

	// Start is called before the first frame update
	void Start()
    {
		_rigidbody = GetComponent<Rigidbody>();

		isForward = false;
		isBack = false;
		isRight = false;
		isLeft = false;
		isJump = false;

		isRotate_R = false;
		isRotate_L = false;

		offsetPos = Player.GetComponent<Transform>().localPosition - m_camera.GetComponent<Transform>().localPosition;
	}

    // Update is called once per frame
    void Update()
	{
		//m_camera.GetComponent<Transform>().localPosition = Player.GetComponent<Transform>().localPosition - offsetPos;

		//m_camera.GetComponent<Transform>().localRotation = Player.GetComponent<Transform>().localRotation;

		Monitor();
	}

	private void FixedUpdate()
	{
		if(isForward == true)
		{
			goForward();
		}
		else if (isBack == true)
		{
			goBack();
		}
		else if (isRight == true)
		{
			goRight();
		}
		else if (isLeft == true)
		{
			goLeft();
		}
		else if (isJump == true)
		{
			Jump();
		}
		else if (isRotate_L == true)
		{
			rotateLeft();
		}
		else if (isRotate_R == true)
		{
			rotateRight();
		}
	}

	void Monitor()
	{
		// Move
		if (Input.GetKeyDown(KeyCode.W))
		{
			isForward = true;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			isBack = true;
		}
		else if (Input.GetKeyDown(KeyCode.A))
		{
			isLeft = true;
		}
		else if (Input.GetKeyDown(KeyCode.D))
		{
			isRight = true;
		}
		else if (Input.GetKeyDown(KeyCode.Space))
		{
			isJump = true;
		}

		// Stop
		if (Input.GetKeyUp(KeyCode.W))
		{
			isForward = false;
		}
		else if (Input.GetKeyUp(KeyCode.S))
		{
			isBack = false;
		}
		else if (Input.GetKeyUp(KeyCode.A))
		{
			isLeft = false;
		}
		else if (Input.GetKeyUp(KeyCode.D))
		{
			isRight = false;
		}

		// Rotation
		if (Input.GetKeyDown(KeyCode.Q))
		{
			isRotate_L = true;
		}
		else if (Input.GetKeyDown(KeyCode.E))
		{
			isRotate_R = true;
		}

		if (Input.GetKeyUp(KeyCode.Q))
		{
			isRotate_L = false;
		}
		else if (Input.GetKeyUp(KeyCode.E))
		{
			isRotate_R = false;
		}
	}

	void goForward()
	{
		_rigidbody.velocity = new Vector3(0, 0, 5);
	}

	void goBack()
	{
		_rigidbody.velocity = new Vector3(0, 0, -5);
	}

	void goRight()
	{
		_rigidbody.velocity = new Vector3(5, 0, 0);
	}

	void goLeft()
	{
		_rigidbody.velocity = new Vector3(-5, 0, 0);
	}

	void Jump()
	{
		_rigidbody.AddForce(0, 5, 0, ForceMode.Impulse);
		isJump = false;
	}

	void rotateRight()
	{
		_rigidbody.angularVelocity = new Vector3(0, 5, 0);
	}

	void rotateLeft()
	{
		_rigidbody.angularVelocity = new Vector3(0, -5, 0);
	}
}
