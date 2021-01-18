using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 追加

public class Timer : MonoBehaviour
{
    float startTime;

    void Start()
    {
    }

    void Update()
    {
        // キー押し始め
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startTime = Time.time;
        }
        // キー放し
        if (Input.GetKeyUp(KeyCode.Space))
        {
            float diffTime = 10.0f - Mathf.Abs(Time.time - startTime);
            AllSceneData.score = 100.0f - diffTime * 10.0f;
            // スコアに応じてシーン切り替え
            if (AllSceneData.score > 80)
            {
                SceneManager.LoadScene("Result");
            }
            else if (AllSceneData.score > 50)
            {
                SceneManager.LoadScene("Result");
            }
            else
            {
                SceneManager.LoadScene("Result");
            }
        }
    }
}
