using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gold : MonoBehaviour
{
    public GameObject pic1;
    public GameObject pic2;
    public GameObject pic3;
    public GameObject pic4;
    public GameObject pic5;
    public GameObject pic6;
    public float health = 100;
    public float golod = 0;
    public float secondsToHealth = 60f;
    public float secondsToGolod = 60f;




    void Start()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        health = 100;
        golod = 0;
    }

    void Update()
    {
        bool points = trigger.points;
        if (points == true)
        {
            if (health > 0)
            {
                health -= 100 / secondsToHealth * Time.deltaTime;
            }
            if (health < 100 & health > 60)
            {
                Swap4();
            }
            if (health <60 & health > 30)
            {
                Swap5();
            }
            if (health < 30)
            {
                Swap6();
            }

        }
        if (points == false)
        {
            pic4.SetActive(false);
            pic5.SetActive(false);
            pic6.SetActive(false);
            health = 100;
        }
            if (health > 0)
        {
            health -= 100 / secondsToHealth * Time.deltaTime;
        }

        if (golod < 100)
        {
            golod += 100 / secondsToGolod * Time.deltaTime;
        }
        if (golod > 29 & golod < 60)
        {
            Swap1();
        }
        if (golod > 60 & golod < 90)
        {
            Swap2();
        }
        if (golod > 90)
        {
            Swap3();
        }
    }
    public void Swap1()
    {
        pic1.SetActive(true);
        pic2.SetActive(false);
        pic3.SetActive(false);

    }
    public void Swap2()
    {
        pic2.SetActive(true);
        pic1.SetActive(false);
        pic3.SetActive(false);
    }
    public void Swap3()
    {
        pic3.SetActive(true);
        pic1.SetActive(false);
        pic2.SetActive(false);
    }
    public void Swap4()
    {
        pic4.SetActive(true);
        pic5.SetActive(false);
        pic6.SetActive(false);
    }
    public void Swap5()
    {
        pic5.SetActive(true);
        pic4.SetActive(false);
        pic6.SetActive(false);
    }
    public void Swap6()
    {
        pic6.SetActive(true);
        pic4.SetActive(false);
        pic5.SetActive(false);
    }
}
