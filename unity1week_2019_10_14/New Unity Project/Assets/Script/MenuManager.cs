using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
