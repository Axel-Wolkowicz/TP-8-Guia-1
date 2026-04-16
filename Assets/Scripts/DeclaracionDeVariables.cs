using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    public int entero = 1;
    public float flotante = 1.45f;
    public string texto = "hola";
    public bool boleano = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(entero);
        Debug.Log(flotante);
        Debug.Log(texto);
        Debug.Log(boleano);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
