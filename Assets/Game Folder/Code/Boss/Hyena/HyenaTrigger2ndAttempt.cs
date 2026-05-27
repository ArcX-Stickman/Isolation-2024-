using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyenaTrigger2ndAttempt : MonoBehaviour
{

    public Player Jamal;
    public Hyena Hyena;
    public GameObject HyenaBossBoi;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Jamal.HyenaFightCameraSet == true)
        {
            HyenaBossBoi.gameObject.SetActive(true);
        }
        
    }
}
