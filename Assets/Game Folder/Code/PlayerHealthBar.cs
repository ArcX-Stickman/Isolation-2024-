using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Player PlayerHP;

    public Slider slider;

    public Image HPdisplay;



    public void MaxHP()
    {
        slider.maxValue = PlayerHP.StartHP;
        slider.value = PlayerHP.PlayerHealth;
        

    }


    public void SetHP()
    {
        slider.value = PlayerHP.PlayerHealth;

    }

    private void Update()
    {
        slider.maxValue = PlayerHP.StartHP;

        slider.value = PlayerHP.PlayerHealth;


        if (slider.value > 13)
        {
            HPdisplay.color = Color.green;
        }

        if (slider.value <= 13)
        {
            HPdisplay.color = Color.yellow;
        }

        if (slider.value <= 6)
        {
            HPdisplay.color = Color.red;
        }


    }




}
