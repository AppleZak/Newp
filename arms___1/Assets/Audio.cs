using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource audio;


    void OnCollisionEnter(Collision collision)
    {
        audio.Play();
    }

    // Update is called once per frame
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetButtonDown(buttonName:"Jump"))
        {
            audio.Play();
        }
    }
}
