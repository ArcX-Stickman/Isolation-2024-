using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMusic : MonoBehaviour
{

    public JoeDied JD;
    public Player Jamal;


    // Start is called before the first frame update
    void Start()
    {
        JD.Music = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            JD.Music = true;
            Jamal.BossCanSet = true;
            Destroy(gameObject);
        }
    }
}
