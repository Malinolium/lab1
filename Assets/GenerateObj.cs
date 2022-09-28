using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
InputField input; int number; int.TryParse(input.text, out int result); number = result;

public class GenerateObj : MonoBehaviour
{

    public GameObject[] obj;
    public InputField NumberCubes;

    // Start is called before the first frame update
    public void Start()
    {
        for(int i = 0; i < NumberCubes; i++)
        {
          Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomNumber() , 0 , RandomNumber() ), Quaternion.Euler(RandomNumber(), RandomNumber() , RandomNumber() ));
        }
    }

    private int RandomNumber() 
    {
        return Random.Range(0, 10);
    }
    public void Continue_menu()
        {
           

        }
    

}
