using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    CamaraAcciones camOptions;

    public GameObject MenuOpciones;
    public GameObject MenuCamara;
    public GameObject MenuCrear;
    public GameObject MenuInformacion;
    public GameObject MenuEliminar;
    public GameObject MenuEditar;

    public Button botonMover;
    public Button botonArbol;
    public Button botonArbol2;
    public Button botonCasa;
    public Button botonEspecial;

    public bool camaraMode { get; set; }
    public bool createMode { get; set; }
    public bool editMode { get; set; }
    public bool deleteMode { get; set; }

    public bool treeCreate { get; set; }
    public bool tree2Create { get; set; }
    public bool houseCreate { get; set; }
    public bool specialCreate { get; set; }
    public bool moveStructure { get; set; }
    public bool decreaseScale { get; set; }
    public bool increaseScale { get; set; }

    private void Start()
    {
        camaraMode = false;
        createMode = false;
        treeCreate = false;
        tree2Create = false;
        houseCreate = false;
        specialCreate = false;
        moveStructure = false;
        decreaseScale = false;
        increaseScale = false;
    }

    void Update()
    {
        if (moveStructure)
        {
            botonMover.image.color = Color.green;
        }
        else
        {
            botonMover.image.color = Color.white;
        }

        if (treeCreate)
        {
            botonArbol.image.color = Color.green;
        }
        else
        {
            botonArbol.image.color = Color.white;
        }

        if (tree2Create)
        {
            botonArbol2.image.color = Color.green;
        }
        else
        {
            botonArbol2.image.color = Color.white;
        }

        if (houseCreate)
        {
            botonCasa.image.color = Color.green;
        }
        else
        {
            botonCasa.image.color = Color.white;
        }

        if (specialCreate)
        {
            botonEspecial.image.color = Color.green;
        }
        else
        {
            botonEspecial.image.color = Color.white;
        }
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

    public void InformationMode()
    {
        createMode = true;

        MenuOpciones.SetActive(false);
        MenuInformacion.SetActive(true);
    }

    public void ExitInformationMode()
    {
        createMode = false;

        MenuInformacion.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void EditMode()
    {
        editMode = true;

        MenuOpciones.SetActive(false);
        MenuEditar.SetActive(true);
    }

    public void EditStructure()
    {
        if (moveStructure)
        {
            moveStructure = false;
        }
        else
        {
            moveStructure = true;
        }
    }

    public void ExitEditMode()
    {
        editMode = false;

        MenuEditar.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void DeleteMode()
    {
        deleteMode = true;

        MenuOpciones.SetActive(false);
        MenuEliminar.SetActive(true);
    }

    public void ExitDeleteMode()
    {
        deleteMode = false;

        MenuEliminar.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void ArbolCrear()
    {
        treeCreate = true;
        tree2Create = false;
        houseCreate = false;
        specialCreate = false;
    }

    public void Arbol2Crear()
    {
        treeCreate = false;
        tree2Create = true;
        houseCreate = false;
        specialCreate = false;
    }

    public void CasaCrear()
    {
        treeCreate = false;
        tree2Create = false;
        houseCreate = true;
        specialCreate = false;
    }

    public void EspecialCrear()
    {
        treeCreate = false;
        tree2Create = false;
        houseCreate = false;
        specialCreate = true;
    }

    public void DecreaseScale()
    {
        decreaseScale = true;
    }

    public void IncreaseScale()
    {
        increaseScale = true;
    }

    public Vector3 DecreaseScaleAction(Vector3 scaleOld)
    {
        decreaseScale = false;

        return new Vector3(scaleOld.x - 0.5f, scaleOld.y - 0.5f, scaleOld.z - 0.5f);
    }

    public Vector3 IncreaseScaleAction(Vector3 scaleOld)
    {
        increaseScale = false;

        return new Vector3(scaleOld.x + 0.5f, scaleOld.y + 0.5f, scaleOld.z + 0.5f);
    }
}

