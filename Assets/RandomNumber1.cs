using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1から10までから生成
        int index = Random.Range(0, 9);

        // サイコロの目を取得する
        int pips = dice[index];
        Debug.Log("10面体サイコロの生成結果は " + pips + " でした。");
    }

    // Update is called once per frame
    void Update()
    {

    }
}