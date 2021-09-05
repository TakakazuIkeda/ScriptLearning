using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int Number = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (Number % 2 == 0)
            Debug.Log(Number + "は偶数です。");
        else if (Number % 2 == 1)
            Debug.Log(Number + "は奇数です。");
        else
            Debug.Log(Number + "は整数ではありません。");
   
        if (Number > 0 && Number % 4 == 0)
            Debug.Log("西暦" + Number + "年はうるう年です。2月29日があります");
        else if (Number > 0 && Number % 4 == 1)
            Debug.Log("西暦" + Number + "年はうるう年ではなく、2月29日がありません");
        else if (Number > 0 && Number % 4 == 2)
            Debug.Log("西暦" + Number + "年はうるう年ではなく、2月29日がありません");
        else if (Number > 0 && Number % 4 == 3)
            Debug.Log("西暦" + Number + "年はうるう年ではなく、2月29日がありません");
        else
            Debug.Log(Number + "は自然数ではありません。");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
