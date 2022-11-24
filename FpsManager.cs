using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FpsManager : MonoBehaviour
{
    public TextMeshProUGUI text;

    float deltaTime = 0.0f;

    private void Start()
    {
#if UNITY_EDITOR
        Application.targetFrameRate = 999;
#endif
    }
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        text.text = string.Format("{0:0.0} ms \n({1:0.} FPS)", msec, fps);
    }
}