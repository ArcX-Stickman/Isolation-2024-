using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public AudioSource AudioPlayer;
    public AudioClip Click;
    public AudioClip Dehydrated;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    public void Easy()
    {
        AudioPlayer.PlayOneShot(Click);
        SceneManager.LoadScene("Easy");

    }

    public void Normal()
    {
        AudioPlayer.PlayOneShot(Click);
        SceneManager.LoadScene("Normal");

    }


    public void Hard()
    {
        AudioPlayer.PlayOneShot(Click);
        SceneManager.LoadScene("Hard");

    }


    public void DehydratedMode()
    {
        AudioPlayer.PlayOneShot(Dehydrated);
        SceneManager.LoadScene("Dehydrated");

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
