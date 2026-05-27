using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedkitHandle : MonoBehaviour
{
    public Player playerObject;
    


   

    public void Meddy()
    {
        playerObject.PlayerHealth = playerObject.PlayerHealth + 4;
    }

   
}
