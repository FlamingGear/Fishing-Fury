using UnityEngine;
using System;

/// <summary>
/// Makes the ship bob up and down on the water.
/// </summary>

public class Ship : MonoBehaviour 
{
    public ShipPlug[] plugs;
    private Vector3 position;
    private int speed;           //measured in PPF (Pixels Per Frame)

    //Unity's version of initializing
    void Start()
    {
        speed = 10;
        plugs = new ShipPlug[4];
        plugs[0] = new Rod();
    }

    // Update is called once per frame
    void Update()
    {       
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            position.x -= speed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            position.x += speed;
        }
    }

    //Called at the rate of the fixed framerate, better for updating physics engines,
    //because this rate varies less. Hence the ACTUAL update being here.
    void FixedUpdate()
    {
        transform.position += position;
    }
}
