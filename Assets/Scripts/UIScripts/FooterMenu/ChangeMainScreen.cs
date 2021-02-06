using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMainScreen : MonoBehaviour
{
    [SerializeField] private GameObject[] ActionScreens;
    void Start()
    {
        hideAllActionScreens();
        changeActionScreen(0);
    }

    void Update()
    {
        
    }

    public void changeActionScreen(int screenIndex)
    {
        hideAllActionScreens();
        ActionScreens[screenIndex].SetActive(true);
    }

    public void hideAllActionScreens()
    {
        foreach (GameObject item in ActionScreens)
        {
            item.SetActive(false);
        }
    }
}
