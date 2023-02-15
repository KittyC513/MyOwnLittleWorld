using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxValue;
    public int currentValue;

    //public float speed; //character move speed
    public Vector3 target;

    public Animator animator;

    private bool isWalking = false;


    public MentalHealthBar mentalHealthBar;

    bool hitBoundary = false;
    //GameObject[] walls;

    // Start is called before the first frame update
    void Start()
    {
        currentValue = maxValue;
        mentalHealthBar.SetMaxValue(maxValue);

        currentValue = 90;
        mentalHealthBar.SetValue(currentValue);

        target = transform.position; // original position

        animator = this.GetComponent<Animator>();

        //walls = GameObject.FindGameObjectsWithTag("Walls");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z; // 2d dimension

        }
        Move(5);

        


    }

    public void DecreaseMentalHealth(int value)
    {
        currentValue -= value;
        mentalHealthBar.SetValue(currentValue);
    }

    void Move(float speed)
    {
        animator.SetBool("isWalking", true);
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(this.transform.position == target)
        {
            animator.SetBool("isWalking", false);
        }
    }




    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag==("Walls"))
        {
            hitBoundary = true;
            Move(0);;
            animator.SetBool("isWalking", false);
        }
        else
        {
            hitBoundary = false;
        }
        
    }*/
}
