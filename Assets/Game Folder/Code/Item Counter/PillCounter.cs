using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PillCounter : MonoBehaviour
{
    public static PillCounter instance;

    public TMP_Text WoodText;
    public int CurrentPills = 0;
    public Player Jamal;

    void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        WoodText.text = CurrentPills.ToString();
    }

    public void AddStone(int v)
    {
        CurrentPills += v;
        WoodText.text = CurrentPills.ToString();
    }


  


}
