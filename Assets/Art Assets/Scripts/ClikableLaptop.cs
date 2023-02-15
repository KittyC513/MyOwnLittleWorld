using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClikableLaptop : MonoBehaviour
{
    public GameObject laptopUI;
    public Actionpoint actionPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        laptopUI.SetActive(true);
        actionPoint.energy -= 1;
    }
}
