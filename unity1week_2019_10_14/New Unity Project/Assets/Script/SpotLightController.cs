using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightController : MonoBehaviour
{
    [SerializeField]
    private GameObject light;

    // 位置座標
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;
    // Use this for initialization
    void Start()
    {
        Debug.Log(this.light.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3でマウス位置座標を取得する
        position = Input.mousePosition;
        // Z軸修正
        position.z = light.transform.position.z;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        // ワールド座標に変換されたマウス座標を代入
        this.light.transform.position = screenToWorldPointPosition;

        Debug.Log(this.light.transform.position);

        // TODO: マウスとライトの位置が修正出来たら適応

        //Vector3 touchScreenPosition = Input.mousePosition;

        //touchScreenPosition.x = Mathf.Clamp(touchScreenPosition.x, 0.0f, Screen.width);
        //touchScreenPosition.y = Mathf.Clamp(touchScreenPosition.y, 0.0f, Screen.height);

        //touchScreenPosition.z = 0.8f;

        //Camera gameCamera = Camera.main;
        //Vector3 touchWorldPosition = gameCamera.ScreenToWorldPoint(touchScreenPosition);

        //light.transform.position = touchWorldPosition;
    }
}
