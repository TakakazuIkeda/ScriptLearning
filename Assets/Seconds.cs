using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seconds : MonoBehaviour
{
    public int Number = 0;

    // Start is called before the first frame update
    void Start()
    {
        int aaa
        {
            int h = (int)(Number / 3600);//秒から時間の値を取得
            int m = (int)(Number / 60);//秒から分の値を取得
            int s = (int)(Number);//秒のみを取得
            return h.ToString("00") + ":" + m.ToString("00") + ":" + s.ToString("00");
        }
        Debug.Log("aaa");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
