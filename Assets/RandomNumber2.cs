using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            // 乱数の範囲指定で配列のインデックスを取得する
            int index = Random.Range(0, 5);

            // サイコロの目を取得する
            int pips = dice[index];
            Debug.Log("サイコロの目は " + pips + " でした。");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
