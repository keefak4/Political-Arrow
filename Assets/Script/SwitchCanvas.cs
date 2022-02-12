using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SwitchCanvas : MonoBehaviour
{

    [SerializeField] private GameObject[] canvasExit;
    [SerializeField] private GameObject canvasOpen;

    public void CliskSwitch()
    {
        for (int i = 0;i < canvasExit.Length;i++)  
        {
            canvasExit[i].SetActive(false);
        }
        canvasOpen.SetActive(true);
    }
}
