using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabuleiroBehaviour : MonoBehaviour
{
    RaycastHit2D mouse;
    GameObject clone;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouse = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);
            if (mouse.collider != null && mouse.collider.gameObject.tag == "Pino")
            {
                clone = mouse.collider.gameObject;
                clone.GetComponent<PinoBehaviour>().Drag = true;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if(clone != null && clone.GetComponent<PinoBehaviour>().Drag)
            {
                clone.GetComponent<PinoBehaviour>().Drag = false;
            }
        }
    }
}