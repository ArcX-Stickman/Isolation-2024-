using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColli : MonoBehaviour
{

    public Player Jamal;
    public bool TouchTreeScriptOther;
    
    // Start is called before the first frame update
    void Start()
    {
        TouchTreeScriptOther = false;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "tree")
        {
            Jamal.PlayerIsTouchingTree = true;
            Jamal.Cuttable = true;
            Jamal.PlayerIsTouchingTree = true;
            TouchTreeScriptOther = true;
         
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
