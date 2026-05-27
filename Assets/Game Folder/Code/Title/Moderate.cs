using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moderaate : MonoBehaviour
{

    public Player Jamal;
    public Hyena hyena;


    // Start is called before the first frame update
    void Start()
    {
        Jamal.NormalMode = true;
        hyena.Medium = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        Jamal.NormalMode = true;
        hyena.Medium = true;

    }
}
