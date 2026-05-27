using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dehydrated : MonoBehaviour
{

    public Player Jamal;
    public Hyena hyena;


    // Start is called before the first frame update
    void Start()
    {
        Jamal.Dehydrated = true;
        hyena.Dehydrated = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        Jamal.Dehydrated = true;
        hyena.Dehydrated = true;
        
    }
}
