using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Actionpoint : MonoBehaviour
{

    public int energy;
    public int numOfenergy;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public GameObject bed;
    public GameObject laptop;


    // Start is called before the first frame update
    void Start()
    {
        energy = 1;
        numOfenergy = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(energy <= 0)
        {
            laptop.SetActive(false);

        }else if(energy > 0)
        {

            laptop.SetActive(true);
        }

        if(energy > numOfenergy)
        {
            energy = numOfenergy;
        }
        for(int i =0; i < hearts.Length; i++)
        {
            if(i < energy)
            {
                hearts[i].sprite = fullHeart;
            } else
            {
                hearts[i].sprite = emptyHeart;
            }
            if(i < numOfenergy)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void ReducePoint(int value)
    {
        energy -= value;
    }

}
