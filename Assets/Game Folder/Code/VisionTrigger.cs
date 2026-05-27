using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionTrigger : MonoBehaviour
{
    public Roamer Health;
    public VisionCH1 VCH1;
    public bool isDead = false;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Health.vi :raj:::" + Health.visionCH1);
        Debug.Log("Health.roamerHP :::::" + Health.roamerHP);
        Debug.Log("Health.vi ::::" + Health.visionCH1);
        int intValue = (int)System.Math.Round(Health.roamerHP);
        Debug.Log("HintValue:::" + intValue);
        if (intValue <= 0)
        {

            Debug.Log("Trigger Count: :::::::::: "+ VCH1.EnemyCount);
            VCH1.EnemyCount ++;
            Destroy(gameObject);
        }


    }
}