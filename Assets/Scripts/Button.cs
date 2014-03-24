using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour 
{
    public Texture regularButton;
    public Texture litButton;

	// Update is called once per frame
	void Update () 
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        
        if(hit.collider != null)

        {
            Debug.Log("object clicked: "+hit.collider.tag);
        }
	}
}
