using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CottageData
{
    // Build Costs
    public static float buildTime;
    public static int grainCost = 0;
    public static int lumberCost = 50;
    public static int sterlingCost = 10;

    // Upkeep Costs
    public static int grainUpkeep = 0;
    public static int lumberUpkeep = 3;
    public static int sterlingUpkeep = 0;

    // Benefits
    public static int populationCapIncrease = 15;
    public static int grainIncrease;
    public static int lumberIncrease;
    public static int sterlingIncrease;
}

public static class FarmData
{
    // Build Costs
    public static float buildTime;
    public static int grainCost = 10;
    public static int lumberCost = 10;
    public static int sterlingCost = 0;

    // Upkeep Costs
    public static int grainUpkeep = 10; //only applied in spring, check the UpkeepCost function
    public static int lumberUpkeep = 0;
    public static int sterlingUpkeep = 0;

    // Benefits
    public static int populationCapIncrease = 5;
    public static int grainIncrease = 80;
    public static int lumberIncrease;
    public static int sterlingIncrease;
}

public static class MillData
{
    // Build Costs
    public static float buildTime;
    public static int grainCost = 10;
    public static int lumberCost = 0;
    public static int sterlingCost = 10;

    // Upkeep Costs
    public static int grainUpkeep = 3;
    public static int lumberUpkeep = 0;
    public static int sterlingUpkeep = 0;

    // Benefits
    public static int populationCapIncrease;
    public static int grainIncrease;
    public static int lumberIncrease = 2;
    public static int sterlingIncrease;
}

public static class MarketData
{
    // Build Costs
    public static float buildTime;
    public static int grainCost = 15;
    public static int lumberCost = 50;
    public static int sterlingCost = 20;

    // Upkeep Costs
    public static int grainUpkeep = 0;
    public static int lumberUpkeep = 1;
    public static int sterlingUpkeep = 2;

    // Benefits
    public static int populationCapIncrease;
    public static int grainIncrease;
    public static int lumberIncrease;
    public static int sterlingIncrease = 50;
}

public static class FortData
{
    // Build Costs
    public static float buildTime;
    public static int grainCost;
    public static int lumberCost;
    public static int sterlingCost;

    // Upkeep Costs
    public static int grainUpkeep;
    public static int lumberUpkeep;
    public static int sterlingUpkeep;

    // Benefits
    public static int populationCapIncrease;
    public static int grainIncrease;
    public static int lumberIncrease;
    public static int sterlingIncrease;
}