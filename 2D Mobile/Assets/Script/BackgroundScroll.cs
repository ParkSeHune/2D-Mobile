using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroll : MonoBehaviour
{
    private Rect rect;
    private RawImage background;


    void Start()
    {
        background = GetComponent<RawImage>();
    }

    void Update()
    {
        Scroll(0.05f);
    }

    public void Scroll(float speed)
    {
        rect = background.uvRect;

        rect.x += Time.deltaTime * speed;

        background.uvRect = rect;
    }
}
