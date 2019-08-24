using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
	float fadeSpeed = 0.02f;
	float red, green, blue, alfa, alfa_m;
	// Start is called before the first frame update
	void Start()
    {
		red = GetComponent<Image>().color.r;
		green = GetComponent<Image>().color.g;
		blue = GetComponent<Image>().color.b;
		alfa = GetComponent<Image>().color.a;
		alfa_m = alfa;
		alfa = 0;
	}

    // Update is called once per frame
    void Update()
    {
		if(alfa <= alfa_m)
		{
			Fadein();
		}
	}

	void Fadein()
	{
		alfa += fadeSpeed;
		GetComponent<Image>().color = new Color(red, green, blue, alfa);
	}
}
