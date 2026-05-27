using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoneCounter : MonoBehaviour
{
    public static StoneCounter instance;

    public TMP_Text StoneText;
    public int CurrentStone = 0;
    public Player Jamal;

    void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        StoneText.text = CurrentStone.ToString();
    }

    public void AddStone(int v)
    {
        CurrentStone += v;
        StoneText.text = CurrentStone.ToString();
    }


   


}
