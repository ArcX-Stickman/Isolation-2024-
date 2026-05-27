using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M : MonoBehaviour
{
    public Player Jamal;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Jamal.HyenaFightCameraSet == true)
        {
            Destroy(gameObject);
        }
        
    }
}
