using System;

namespace FishingFuryLib
{
    class Rod : ShipPlug
    {
        int[] hookUpgrades = { 0, 1, 2, 3, 4 };

        int hookCount;  //Number of fish that can be hooked at once

        bool Upgrade(upgradeTypes type)
        {
            switch (type)
            {
                case upgradeTypes.netSz:    return false;  //Return code for if an impossible upgrade is attempted

                case upgradeTypes.hkCt:     if (hookCount == hookUpgrades[hookUpgrades.Length])
                                            {//If it is at max upgrade level, do nothing
                                                break;
                                            }

                                            for (int i = 0; i < (hookUpgrades.Length - 1); i++)
                                            {//Otherwise, loop through the array until you find what upgrade it
                                             //is at, then increase it to the next level.
                                                if (hookCount == hookUpgrades[i])
                                                {
                                                    hookCount = hookUpgrades[i + 1];
                                                    break;
                                                }
                                            }
                                            break;

                case upgradeTypes.lnSpd: if (lineSpeed == speedUpgrades[speedUpgrades.Length])
                                            {//If it is at max upgrade level, do nothing
                                                break;
                                            }

                                            for (int i = 0; i < (speedUpgrades.Length - 1); i++)
                                            {//Otherwise, loop through the array until you find what upgrade it
                                                //is at, then increase it to the next level.
                                                if (lineSpeed == speedUpgrades[i])
                                                {
                                                    lineSpeed = speedUpgrades[i + 1];
                                                    break;
                                                }
                                            }
                                            break;

                case upgradeTypes.lnStr: if (strength == strengthUpgrades[strengthUpgrades.Length])
                                            {//If it is at max upgrade level, do nothing
                                                break;
                                            }

                                            for (int i = 0; i < (strengthUpgrades.Length - 1); i++)
                                            {//Otherwise, loop through the array until you find what upgrade it
                                                //is at, then increase it to the next level.
                                                if (strength == strengthUpgrades[i])
                                                {
                                                    strength = strengthUpgrades[i + 1];
                                                    break;
                                                }
                                            }
                                            break;

                case upgradeTypes.rstTm: if (resetTime == resetUpgrades[resetUpgrades.Length])
                                            {//If it is at max upgrade level, do nothing
                                                break;
                                            }

                                            for (int i = 0; i < (resetUpgrades.Length - 1); i++)
                                            {//Otherwise, loop through the array until you find what upgrade it
                                                //is at, then increase it to the next level.
                                                if (resetTime == resetUpgrades[i])
                                                {
                                                    resetTime = resetUpgrades[i + 1];
                                                    break;
                                                }
                                            }
                                            break;
            }

            return true;
        }

        int GetUpgradeLevel(upgradeTypes type)
        {
            switch (type)
            {
                case upgradeTypes.netSz: return -1;  //Return code for if an impossible upgrade is attempted

                case upgradeTypes.hkCt: for (int i = 0; i < (hookUpgrades.Length - 1); i++)
                                        {//Otherwise, loop through the array until you find what upgrade it
                                            //is at, then increase it to the next level.
                                            if (hookCount == hookUpgrades[i])
                                            {
                                                return i;
                                            }
                                        }
                                        break;

                case upgradeTypes.lnSpd: for (int i = 0; i < (speedUpgrades.Length - 1); i++)
                                         {//Otherwise, loop through the array until you find what upgrade it
                                            //is at, then increase it to the next level.
                                            if (lineSpeed == speedUpgrades[i])
                                            {
                                                return i;
                                            }
                                         }
                                         break;

                case upgradeTypes.lnStr: for (int i = 0; i < (strengthUpgrades.Length - 1); i++)
                                         {//Otherwise, loop through the array until you find what upgrade it
                                            //is at, then increase it to the next level.
                                            if (strength == strengthUpgrades[i])
                                            {
                                                return i;
                                            }
                                         }
                                         break;

                case upgradeTypes.rstTm: for (int i = 0; i < (resetUpgrades.Length - 1); i++)
                                         {//Otherwise, loop through the array until you find what upgrade it
                                            //is at, then increase it to the next level.
                                            if (resetTime == resetUpgrades[i])
                                            {
                                                return i;
                                            }
                                         } 
                                         break;
            }

            return -1;
        }
    }
}
