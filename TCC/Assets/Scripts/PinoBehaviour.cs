using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PinoBehaviour : MonoBehaviour
{
    Vector3 oldPosition;
    Vector3 objSave;
    RaycastHit2D[] mouse;
    int contador;
    [SerializeField] bool mover = false;
    string nome;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        if (Input.GetMouseButtonDown(0))
        {
            mouse = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);
            foreach (var item in mouse)
            {
                if(item.collider.tag == "Pino" && item.collider.gameObject.name == gameObject.name)
                {
                    mover = true;
                    oldPosition = transform.position;
                }
                if (item.collider.gameObject.tag == "Pino")
                    contador++;
                if (contador != 1 && contador == mouse.Length + 1 || contador == mouse.Length)
                {
                    transform.position = oldPosition;
                    mover = false;
                }
            }
        }
        if (Input.GetMouseButton(0))
        {
            if (mover)
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0,0,10);
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (mover)
            {
                mouse = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);
                foreach (var x in mouse)
                {
                    if (x.collider.gameObject.tag == "Pino")
                        contador++;
                    if(contador != 1 && contador == mouse.Length + 1 || contador == mouse.Length)
                    {
                        transform.position = oldPosition;
                    }
                }
                if (contador == mouse.Length)
                {
                    transform.position = oldPosition;
                }
                contador = 0;
                mover = false;
            }
            //switch (mouse.collider.gameObject.name.Substring(3, 2))
            //{
            //case "01":
            //    break;
            //case "02":
            //    break;
            //case "03":
            //    break;
            //case "04":
            //    break;
            //case "05":
            //    break;
            //case "06":
            //    break;
            //case "07":
            //    break;
            //case "08":
            //    break;
            //case "09":
            //    break;
            //case "10":
            //    break;
            //case "11":
            //    break;
            //case "12":
            //    break;
            //case "13":
            //    break;
            //case "14":
            //    break;
            //case "15":
            //    break;
            //case "16":
            //    break;
            //case "17":
            //    break;
            //case "18":
            //    break;
            //case "19":
            //    break;
            //case "20":
            //    break;
            //case "21":
            //    break;
            //case "22":
            //    break;
            //case "23":
            //    break;
            //case "24":
            //    break;
            //case "25":
            //    break;
            //case "26":
            //    break;
            //case "27":
            //    break;
            //case "28":
            //    break;
            //case "29":
            //    break;
            //case "30":
            //    break;
            //case "31":
            //    break;
            //case "32":
            //    break;
            //case "33":
            //    break;
            //case "34":
            //    break;
            //case "35":
            //    break;
            //case "36":
            //    break;
            //case "37":
            //    break;
            //case "38":
            //    break;
            //case "39":
            //    break;
            //case "40":
            //    break;
            //case "41":
            //    break;
            //case "42":
            //    break;
            //case "43":
            //    break;
            //case "44":
            //    break;
            //case "45":
            //    break;
            //case "46":
            //    break;
            //case "47":
            //    break;
            //case "48":
            //    break;
            //case "49":
            //    break;
            //case "50":
            //    break;
            //case "01":
            //    break;

            //     }
        }
        else {
            print("nao devia ter mostrado isso");
        }
    }
}
