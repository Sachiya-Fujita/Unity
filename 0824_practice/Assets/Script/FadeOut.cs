using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FadeOut : MonoBehaviour
{
	bool isFadeOut;

	float fadeSpeed = 0.02f;
	float red, green, blue, alfa;
	// Start is called before the first frame update
	void Start()
	{
		isFadeOut = false;

		red = GetComponent<Image>().color.r;
		green = GetComponent<Image>().color.g;
		blue = GetComponent<Image>().color.b;
		alfa = GetComponent<Image>().color.a;
	}

	// Update is called once per frame
	void Update()
	{
		if (0 <= alfa && isFadeOut == true)
		{
			Fadeout();
		}
		else if (alfa <= 0 && isFadeOut == true)
		{
			SceneManager.LoadScene("MainGame");
		}
	}

	void Fadeout()
	{
		alfa -= fadeSpeed;
		GetComponent<Image>().color = new Color(red, green, blue, alfa);
	}

	public void beginFade()
	{
		isFadeOut = true;
	}
}
