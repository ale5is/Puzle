using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    // Start is called before the first frame update
    public int cantidad;
    public GameObject entrada;
    private void Update()
    {
        entrada.GetComponent<PuertaAparecer>().cantidad=cantidad;
        
    }
}
