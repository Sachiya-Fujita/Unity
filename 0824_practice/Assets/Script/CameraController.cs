using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField]
	private GameObject thirdCam;

	[SerializeField]
	private GameObject firstCam;

    // Start is called before the first frame update
    void Start()
    {
		thirdCam.SetActive(true);
		firstCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Z))
		{
			changeCam();
		}
    }

	void changeCam()
	{
		if(thirdCam.activeSelf == true)
		{
			thirdCam.SetActive(false);
			firstCam.SetActive(true);
		}
		else
		{
			thirdCam.SetActive(true);
			firstCam.SetActive(false);
		}
	}
}
