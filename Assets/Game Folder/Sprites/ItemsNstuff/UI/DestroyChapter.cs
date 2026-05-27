using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyChapter : MonoBehaviour
{
    public GameObject UI;


    // Start is called before the first frame update
    void Start()
    {
        UI.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Delete()
    {
        Destroy(gameObject);
    }
}
