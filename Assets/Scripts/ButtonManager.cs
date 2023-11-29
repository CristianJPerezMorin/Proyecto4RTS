using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject MenuOpciones;
    public GameObject MenuCamara;
    public GameObject MenuCrear;

    public bool camaraMode { get; set; }

    public bool createMode { get; set; }

    private void Start()
    {
        camaraMode = false;
        createMode = false;
    }

    public void CamaraMode()
    {
        camaraMode = true;

        MenuOpciones.SetActive(false);
        MenuCamara.SetActive(true);
    }

    public void ExitCamaraMode()
    {
        camaraMode = false;

        MenuCamara.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void CreateMode()
    {
        createMode = true;

        MenuOpciones.SetActive(false);
        MenuCrear.SetActive(true);
    }

    public void ExitCreateMode()
    {
        createMode = false;

        MenuCrear.SetActive(false);
        MenuOpciones.SetActive(true);
    }
}
