using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJETOMANAGER : MonoBehaviour
{
    public GameObject[] modelos;
    int currentIndex = 3;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        FlechaDer();
        FlechaIzq();
    }
    void FlechaDer()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex += 1;
            if(currentIndex>=modelos.Length)
            {
                currentIndex = 0;
            }
            DeactivateAll();
            ActivateByIndex(currentIndex);
        }
        
    }
    void FlechaIzq()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex -= 1;
            if (currentIndex <= 0)
            {
                currentIndex = modelos.Length-1;
            }
            DeactivateAll();
            ActivateByIndex(currentIndex);
        }

    }
    void DeactivateAll()
    {
        for(int i =0; i<modelos.Length; i++)
        {
            modelos[i].SetActive(false);
        }

    }

    void ActivateByIndex(int index)
    {
        modelos[index].SetActive(true);
    }
    
}
