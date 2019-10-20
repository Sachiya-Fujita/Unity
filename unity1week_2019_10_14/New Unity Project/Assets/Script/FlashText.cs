using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FlashText : MonoBehaviour
{
   
    [SerializeField]
    private GameObject textObject; //点滅させたい文字
    private float nextTime;
    public float interval = 0.8f; //点滅周期
                                  // Use this for initialization
    void Start()
    {
        nextTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        //一定時間ごとに点滅
        if (Time.time > nextTime)
        {
            float alpha = textObject.GetComponent<CanvasRenderer>().GetAlpha();
            if (alpha == 1.0f)
            {
                textObject.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
            }
            else
            {
                textObject.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
            }
            nextTime += interval;
        }
    }

    public void ChangeScene(string btnName)
    {
        switch (btnName)
        {
            case "Top":
                SceneManager.LoadScene("Top");
                break;

            case "Menu":
                SceneManager.LoadScene("Menu");
                break;

            case "Main":
                SceneManager.LoadScene("Main");
                break;

            default:
                break;

        }
    }
}
