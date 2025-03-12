using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public GameObject Spider;
    public Color color;
    public Material colorMaterial;
    public int textRand;
    public Texture[] texturas;
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
        textRand = Random.Range(0, texturas.Length);
        Spider.GetComponentInChildren<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        Spider.GetComponentInChildren<Renderer>().material.mainTexture = texturas[textRand];
        //colorMaterial.color = color; Para modificar múltiples elementos a la vez
    }
}
