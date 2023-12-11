using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionBoton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.transform.position.y == 40)
        {
            gameObject.transform.position = new Vector3(550.5f, -140, 0);
            LeanTween.move(gameObject, new Vector3(550.5f, 40, 0), 1).setEaseInOutSine();
        }
        else
        {
            gameObject.transform.position = new Vector3(1200.5f, 259.5f, 0);
            LeanTween.move(gameObject, new Vector3(940.5f, 259.5f, 0), 1).setEaseInQuint();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
