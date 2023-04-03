using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oiseau : MonoBehaviour
{

    public AudioSource bruitOiseau;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "XR Origin")
        {
            print("La musique joue");
            bruitOiseau.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "XR Origin")
        {
            print("La musique arrete");
            bruitOiseau.Stop();
        }
    }
}
