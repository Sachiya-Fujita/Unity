using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ContentsManager : MonoBehaviour
{

    [SerializeField]
    private GameObject circlePrefab;

    [SerializeField]
    private GameObject wrongPrefab;

    private GameObject circle_;

    [SerializeField]
    private GameObject gameClear;

    [SerializeField]
    private Text correctCount;

    int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator createMark(Vector3 createPos, Transform parent)
    {
        GameObject gameObject = Instantiate(circlePrefab, createPos, Quaternion.identity, parent.transform);
        gameObject.transform.position = new Vector3(createPos.x, createPos.y, 2.6f);

        yield return new WaitForSeconds(0.5f);

        checkCount();
    }

    void checkCount()
    {
        count = gameObject.transform.childCount - 2;
        Debug.Log(count);
        correctCount.text = count.ToString();

        if(count >= 3)
        {
            StartCoroutine(Clear());
        }
    }
    
    IEnumerator Clear()
    {
        gameClear.SetActive(true);

        yield return new WaitForSeconds(2.0f);

        SceneManager.LoadScene("Menu");
    }
}
