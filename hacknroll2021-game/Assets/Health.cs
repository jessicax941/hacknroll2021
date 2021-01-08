using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int numOfLives;
    public Image[] lives;
    public Sprite oneLife;

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < numOfLives; i++)
        //{
        //    if (i < lives.Length)
        //    {
        //        lives[i].sprite = oneLife;
        //    } else
        //    {
        //        lives[i].sprite = null;
        //    }
        //}

        for (int i = 0; i < lives.Length; i++)
        {
            if (i < numOfLives)
            {
                // this life is still valid
                lives[i].sprite = oneLife;
            }
            else
            {
                // this life is not valid
                lives[i].sprite = null;
                lives[i].color = Color.clear;
            }
        }
    }
}
