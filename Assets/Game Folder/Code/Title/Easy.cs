using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy : MonoBehaviour
{

    public Player Jamal;
    public Hyena hyena;


    // Start is called before the first frame update
    void Start()
    {
        Jamal.EasyMode = true;
        hyena.Easy = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        Jamal.EasyMode = true;
        hyena.Easy = true;
    }
}
