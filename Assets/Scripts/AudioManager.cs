using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] protected GameManager gameManager;

    [SerializeField] protected AudioSource gameAudio;

    
    // Start is called before the first frame update
    void Start()
    {
        gameAudio.Play();
        gameAudio.loop = true;
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
