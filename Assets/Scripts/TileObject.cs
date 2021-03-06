﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileObject : MonoBehaviour
{
    public TileType finishedType;
    public TileType startType;
    public SeasonType seasonType;
    public SpriteRenderer render;

    public bool underConstruction = false;
    public float buildTime;
    public float buildCounter;

    public bool isBurning = false;
    int burnTime = 20;
    int burnCounter = 0;


    float tintAmount = 0.95f;

    void Awake()
    {
        render = this.gameObject.GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (isBurning)
        {
            burnCounter++;

            if (burnCounter >= burnTime)
            {
                isBurning = false;
                burnCounter = 0;

                finishedType = TileType.Field;
                startType = TileType.Field;
            }
        }
        
        if (render == null) { render = gameObject.GetComponent<SpriteRenderer>(); }
        if (render != null) { render.sprite = ResourceLoader.GetSpriteSheet(startType)[(int)seasonType]; }

        if (startType != finishedType)
        {
            SetAlpha(0.3f);
        }
        else
        {
            SetAlpha(1.0f);
        }
    }

    // public void BuildBuilding(float time)
    // {
    //     underConstruction = true;
    //     buildTime = time;
        
    //     finishedType = TileType.Fire;
    //     startType = TileType.Fire;
    // }

    public void BurnBuilding()
    {
        isBurning = true;
        finishedType = TileType.Fire;
        startType = TileType.Fire;
    }

    public void SetColor(Color newColor)
    {
        render.color = newColor;
    }

    public void SetAlpha(float newAlpha)
    {
        Color temp = render.color;
        temp.a = newAlpha;
        render.color = temp;
    }

    public void SetCompleteSprite(TileType type)
    {
        finishedType = type;
        startType = type;
    }
}
