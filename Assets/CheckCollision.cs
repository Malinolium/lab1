using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Cube")
        {
        other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        Debug.Log("Произошло столкновение с" + other.gameObject.name);
        }
    }

    private void OnCollisionExit(Collision other) {
         if (other.gameObject.name == "Cube")
        {
        other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        Debug.Log("Прекращено столкновение с" + other.gameObject.name);
        }
    }
}
