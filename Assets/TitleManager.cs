using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 追加
using UnityEngine.UI; // 追加

public class TitleManager : MonoBehaviour
{
    public GameObject titleText;

    // タイトルに戻ってきたときにベストスコアを更新し、現在のスコアをゼロクリア
    void Start()
    {
        Text text = titleText.GetComponent<Text>();
        if (AllSceneData.bestScore < AllSceneData.score)
        {
            AllSceneData.bestScore = AllSceneData.score;
        }
        text.text = "Best score: " + AllSceneData.bestScore.ToString();
        AllSceneData.score = 0;
    }

    void Update()
    {
        
    }

    public void OnPushStartButton()
    {
        SceneManager.LoadScene("Scene1");
    }
}
