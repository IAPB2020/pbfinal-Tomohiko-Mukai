using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 追加
using UnityEngine.SceneManagement; // 追加

public class ResultScript : MonoBehaviour
{
    void Start()
    {
        Text timeText = GetComponent<Text>();
        timeText.text = "RESULT: " + AllSceneData.score.ToString();
    }

    public void OnClickButton()
    {
        SceneManager.LoadScene("Title");
    }
}
