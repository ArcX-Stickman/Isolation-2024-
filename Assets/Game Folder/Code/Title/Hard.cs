using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard : MonoBehaviour
{

    public Player Jamal;
    public Hyena hyena;


    // Start is called before the first frame update
    void Start()
    {
        Jamal.HardMode = true;
        hyena.Hard = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        Jamal.HardMode = true;
        hyena.Hard = true;

    }
}
