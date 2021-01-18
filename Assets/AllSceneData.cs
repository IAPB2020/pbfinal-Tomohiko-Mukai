using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 複数シーンで共通して扱うデータを扱うクラス
public class AllSceneData // MonoBehaviour という文言がない 
{
    // ↓ 全て先頭に「public static」を付記
    public static float score = 0;
    public static float bestScore = 0;
}
