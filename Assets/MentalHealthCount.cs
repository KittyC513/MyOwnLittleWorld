using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MentalHealthCount : MonoBehaviour
{
    public Text mentalHealthValue;
    public int randValue;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateResult()
    {
        randValue = Random.Range(-10, 5);

        if (randValue >= 0)
        {
            mentalHealthValue.text = "Mental Health: +" + randValue + "    (Incompleted) ";
            player.IncreaseMentalHealth(randValue);
        }
        else
        {
            mentalHealthValue.text = "Mental Health: " + randValue + "    (Incompleted) ";
            player.DecreaseMentalHealth(randValue);
        }
        
    }
}
