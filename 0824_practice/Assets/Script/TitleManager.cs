using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleManager : MonoBehaviour
{
	[SerializeField]
	private FadeOut fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("transition");
			Transiton();
		}
	}

	void Transiton()
	{
		fade.beginFade();
		//SceneManager.LoadScene("MainGame");
	}
}
