using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EforCraft : MonoBehaviour
{

    public Player PlayerCheck;
    public GameObject CraftE;
    public GameObject MedM;


    // Start is called before the first frame update
    void Start()
    {
        PlayerCheck.HasBackpack = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerCheck.HasBackpack == true)
        {
            CraftE.gameObject.SetActive(true);
        }
        else
        {
            CraftE.gameObject.SetActive(false);

        }

        if (PlayerCheck.HasMedkit == true)
        {
            MedM.gameObject.SetActive(true);

        }

        if(PlayerCheck.HasMedkit == false)
        {
            MedM.gameObject.SetActive(false);

        }
    }
}
