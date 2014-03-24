using UnityEngine;
using System;

/// <summary>
/// Makes the ship bob up and down on the water.
/// </summary>


public class ShipBob : MonoBehaviour 
{
    private Vector2 position;
    private float yOffset;
    private double iterator;
    
    // Update is called once per frame
	void Update () 
    {
        //Using a sin curve, determine the y position of the ship around its original point
        //Should give the ship a "bobbing on water" effect.
        yOffset = 0.5f + ( (float)Math.Sin(iterator) * 0.1f);

        //Iterating a tiny amount per update means that the ship bobs very slowly, which
        //makes sense for a ship of this size.
        iterator += (Math.PI / 64);

        //Though in terms of sin the iterator could continue forever, eventually the
        //double would exceed its limits, this is here to prevent that.
        if (iterator > 2 * Math.PI)
        {
            iterator -= (4 * Math.PI);
        }

        position = new Vector2(-5, yOffset);
	}

    //Called at the rate of the fixed framerate, better for updating physics engines,
    //because this rate varies less. Hence the ACTUAL update being here.
    void FixedUpdate()
    {
        transform.position = position;
    }
}
