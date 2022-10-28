using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class AtlasManager : MonoBehaviour
{
    [SerializeField] SpriteAtlas atlas;
    [SerializeField] Image testImage;

    void Start()
    {
        //Application.targetFrameRate = 100;

        testImage.sprite = atlas.GetSprite("Coin");
    }

    void Update()
    {
        
    }
}
