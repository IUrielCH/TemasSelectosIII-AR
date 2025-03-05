using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public GameObject Spider;
    public Color color;
    public Material colorMaterial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambioColor_SPD()
    {
        Spider.GetComponentInChildren<Renderer>().material.color = color;
        //colorMaterial.color = color; Para modificar múltiples elementos a la vez
    }
}
