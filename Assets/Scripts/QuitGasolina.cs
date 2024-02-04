using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGasolina : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public int value = 5;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.RestGasoline(value);
            Destroy(gameObject);
        }
    }
}


    

