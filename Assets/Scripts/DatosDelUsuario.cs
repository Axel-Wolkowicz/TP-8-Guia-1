using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombre = "Axel";
    public int edad = 15;
    public float estatura = 1.80f;
    public bool donante = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es "+ nombre + ", tengo " + edad + ", mido " + estatura + " metros y es " + donante + " que soy donante de órganos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
