using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFunction : MonoBehaviour
{
    public GameObject laptop;
    public GameObject laptopUI;
    public GameObject sleepUI;
    public DateCount dateCount;
    public Actionpoint actionPoint;

    public GameObject bottomBar;

    public GameObject bed;
    public Player player;

    public GameObject cc;
    public GameObject loc;
    public GameObject tt;
 


    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // position to the mouse

        RaycastHit2D hit2d = Physics2D.GetRayIntersection(ray);

        //if mouse-left button is pressed, it will raycast a position from mouse to detect if the mouse is clicking an object
        if (Input.GetMouseButtonDown(1))
        {

            if (hit2d.collider != null && hit2d.collider.gameObject.tag == "Laptop" && actionPoint.energy >= 1)
            {
                Debug.Log(99);
                laptopUI.SetActive(true);
                bottomBar.SetActive(true);
  
            }


            if (hit2d.collider != null && hit2d.collider.gameObject.tag == "Bed" && actionPoint.energy < 1)
            {
                //sleepUI.SetActive(true);
                //actionPoint.energy = 3;
                //Debug.Log(999);
                bottomBar.SetActive(false);
                player.IncreaseMentalHealth(5);

                cc.SetActive(true);
                loc.SetActive(true);
                tt.SetActive(true);


            }

        }


    }
}

            
        

    
    


        



