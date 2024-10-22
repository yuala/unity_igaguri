using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera MainCamera;
    public Camera EffectCamera;
    //変化させる時間
    public float tramsitionDuration = 2.0f;
    //カメラの初期位置
    public Vector3 startPosition = new Vector3(0, 1, 3);
    //カメラの終了位置
    public Vector3 endPosition = new Vector3(0, 5, -10);


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CameraTransition());
    }

    private IEnumerator CameraTransition()
    {
        MainCamera.enabled = false;
        EffectCamera.enabled = true;

        EffectCamera.transform.position = startPosition;

        float elapsedTime = 0f;
        while (elapsedTime < tramsitionDuration)
        {
            EffectCamera.transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime/tramsitionDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        //メインカメラを有効化し、演出カメラを無効化する
        EffectCamera.enabled = false;
        MainCamera.enabled = true;
    }
  
}
