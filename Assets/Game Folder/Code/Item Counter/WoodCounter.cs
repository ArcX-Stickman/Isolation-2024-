using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodCounter : MonoBehaviour
{
    public static WoodCounter instance;

    public TMP_Text WoodText;
    public int CurrentWood = 0;
    public Player Jamal;

    void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        WoodText.text = CurrentWood.ToString();
    }

    public void AddWood(int v)
    {
        CurrentWood += v;
        WoodText.text = CurrentWood.ToString();
    }

   

}
