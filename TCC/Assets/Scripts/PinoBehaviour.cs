using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PinoBehaviour : MonoBehaviour
{
    private bool drag;
    public bool Drag { get { return drag; } set { drag = value; } }
    private void Update()
    {
        if (drag)
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0,0,10);
    }
}
