using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UICanvasController : MonoBehaviour
{
    [SerializeField]
    private Button changeButton;

    //[SerializeField]
    //private Image lightOn;

    //[SerializeField]
    //private Image lightOff;

    [SerializeField]
    private GameObject lightOn_;

    [SerializeField]
    private GameObject lightOff_;

    [SerializeField]
    private GameObject wholeLight;


    // Start is called before the first frame update
    void Start()
    {
        //changeButton.image = lightOn;
        wholeLight.SetActive(false);
        lightOn_.SetActive(true);
        lightOff_.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeLight()
    {
        if(wholeLight.activeSelf == false)
        {
            wholeLight.SetActive(true);
            lightOn_.SetActive(false);
            lightOff_.SetActive(true);
            //changeButton.image = lightOff;
        }
        else
        {
            wholeLight.SetActive(false);
            lightOn_.SetActive(true);
            lightOff_.SetActive(false);
            //changeButton.image = lightOn;
        }
    }
}
