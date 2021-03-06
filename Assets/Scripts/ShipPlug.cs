﻿using System;

public class ShipPlug
{
    //Rod and Net inherit from this

    //Used when upgrading to decide what to bump up
    public enum upgradeTypes { lnStr, lnSpd, rstTm, netSz, hkCt };

    public bool exists;

    //Stores the values of the upgrades
    protected int[] speedUpgrades = { 0, 1, 2, 3, 4 };
    protected int[] strengthUpgrades = { 0, 1, 2, 3, 4 };
    protected int[] resetUpgrades = { 0, 1, 2, 3, 4 };

    protected int strength;   //How much weight the line can handle
    protected int resetTime;  //How long it takes to reset the line
    protected int lineSpeed;  //How fast the line moves at fastest (slower if laden)

    //No methods, only the inherited forms are used

    public ShipPlug()
    {
        strength = strengthUpgrades[0];
        resetTime = resetUpgrades[0];
        lineSpeed = speedUpgrades[0];

        exists = false;
    }
}

