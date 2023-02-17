using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DateCount : MonoBehaviour
{
    public int dayValue = 1;
    Text date;
    // Start is called before the first frame update
    void Start()
    {
        date = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        date.text = "DAY " + dayValue;
    }
}
