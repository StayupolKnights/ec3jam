﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Builder : MonoBehaviour
{
    public GameMaster gameMaster;
    public GameObject infoMenu;

    public GameObject spriteObject;
    Image image;

    public TileType buildingType;
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public TextMeshProUGUI cost_time;
    public TextMeshProUGUI cost_grain;
    public TextMeshProUGUI cost_lumber;
    public TextMeshProUGUI cost_sterling;
    public TextMeshProUGUI upkeep_lumber;
    public TextMeshProUGUI upkeep_sterling;

    void Start()
    {
        image = spriteObject.GetComponent<Image>();
        
        switch (buildingType)
        {
            case TileType.Cottage:
                title.text = CottageData.buildingName;
                description.text = CottageData.buildingDescription;
                cost_time.text = CottageData.buildTime.ToString();
                cost_grain.text = CottageData.grainCost.ToString();
                cost_lumber.text = CottageData.lumberCost.ToString();
                cost_sterling.text = CottageData.sterlingCost.ToString();
                upkeep_lumber.text = CottageData.lumberUpkeep.ToString();
                upkeep_sterling.text = CottageData.sterlingUpkeep.ToString();
                break;
            case TileType.Farm:
                title.text = FarmData.buildingName;
                description.text = FarmData.buildingDescription;
                cost_time.text = FarmData.buildTime.ToString();
                cost_grain.text = FarmData.grainCost.ToString();
                cost_lumber.text = FarmData.lumberCost.ToString();
                cost_sterling.text = FarmData.sterlingCost.ToString();
                upkeep_lumber.text = FarmData.lumberUpkeep.ToString();
                upkeep_sterling.text = FarmData.sterlingUpkeep.ToString();
                break;
            case TileType.Mill:
                title.text = MillData.buildingName;
                description.text = MillData.buildingDescription;
                cost_time.text = MillData.buildTime.ToString();
                cost_grain.text = MillData.grainCost.ToString();
                cost_lumber.text = MillData.lumberCost.ToString();
                cost_sterling.text = MillData.sterlingCost.ToString();
                upkeep_lumber.text = MillData.lumberUpkeep.ToString();
                upkeep_sterling.text = MillData.sterlingUpkeep.ToString();
                break;
            case TileType.Market:
                title.text = MarketData.buildingName;
                description.text = MarketData.buildingDescription;
                cost_time.text = MarketData.buildTime.ToString();
                cost_grain.text = MarketData.grainCost.ToString();
                cost_lumber.text = MarketData.lumberCost.ToString();
                cost_sterling.text = MarketData.sterlingCost.ToString();
                upkeep_lumber.text = MarketData.lumberUpkeep.ToString();
                upkeep_sterling.text = MarketData.sterlingUpkeep.ToString();
                break;
        }
        
        infoMenu.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (gameMaster.currentTickCount == 0) {image.sprite = ResourceLoader.GetSpriteSheet(buildingType)[(int)gameMaster.currentSeason.seasonType]; }
        
    }

    public void PointerEnter()
    {
        infoMenu.gameObject.SetActive(true);
    }

    public void PointerExit()
    {
        infoMenu.gameObject.SetActive(false);
    }


    public void BuildCottage()
    {
        gameMaster.BuildBuilding(TileType.Cottage);
        infoMenu.gameObject.SetActive(false);
    }

    public void BuildFarm()
    {
        gameMaster.BuildBuilding(TileType.Farm);
        infoMenu.gameObject.SetActive(false);
    }

    public void BuildMill()
    {
        gameMaster.BuildBuilding(TileType.Mill);
        infoMenu.gameObject.SetActive(false);
    }

    public void BuildMarket()
    {
        gameMaster.BuildBuilding(TileType.Market);
        infoMenu.gameObject.SetActive(false);
    }
}