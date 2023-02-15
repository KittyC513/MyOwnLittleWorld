using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFunction : MonoBehaviour
{
    public GameObject laptop;
    public GameObject laptopUI;
    public GameObject sleepUI;

    int timeOfClick;


    // Start is called before the first frame update
    void Start()
    {
        timeOfClick = 0;
    }



    // Update is called once per frame


    void Update()
    {
        //if mouse-left button is pressed, it will raycast a position from mouse to detect if the mouse is clicking an object
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // position to the mouse
            
            RaycastHit2D hit2d = Physics2D.GetRayIntersection(ray);

            if (hit2d.collider != null && hit2d.collider.gameObject.tag == "Laptop" && timeOfClick < 1)
            {
                Debug.Log(99);
                laptopUI.SetActive(true);
                
                timeOfClick++;
                Debug.Log(timeOfClick);

            } else if (hit2d.collider != null && hit2d.collider.gameObject.tag == "Bed" && timeOfClick >= 1)
            {
                sleepUI.SetActive(true);
                Debug.Log(999);
 
            }


        }
    }
}

            
        

    
    


        



