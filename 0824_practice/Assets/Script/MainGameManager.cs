using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameManager : MonoBehaviour
{
	[SerializeField]
	AudioSource bgm;

	bool isVolumeUp;
	bool isVolumeDown;

    // Start is called before the first frame update
    void Start()
    {
		isVolumeDown = false;
		isVolumeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Return))
		{
			Transiton();
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow)){
			isVolumeUp = true;
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			isVolumeDown = true;
		}

		if (isVolumeUp == true)
		{
			volumeUp();
		}
		else if (isVolumeDown == true)
		{
			volumeDown();
		}

		if (Input.GetKeyUp(KeyCode.UpArrow))
		{
			isVolumeUp = false;
		}
		else if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			isVolumeDown = false;
		}
	}

	void Transiton()
	{
		SceneManager.LoadScene("Result");
	}

	void volumeUp()
	{
		bgm.volume += 0.01f;
	}

	void volumeDown()
	{
		bgm.volume -= 0.01f;
	}
}
