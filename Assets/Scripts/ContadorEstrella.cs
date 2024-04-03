using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorEstrella : MonoBehaviour
{
    public int contador = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Star")
        {
            contador++;
            Destroy(other.gameObject);
            Debug.Log("Se ha añadido 1 punto al score SCORE: "+contador+"");
        }
    }
}
