using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeObject : MonoBehaviour
{
    public GameObject[] productoNumero1;
    public GameObject[] productoNumero2;
    int ProdLadIzq;
    int ProdLadDer;
    public int ValorDeComida;
    // Start is called before the first frame update
    void Start()
    {

        Deactivate();
        Activate();

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void Deactivate()
    {
        for (int i = 0; i < productoNumero1.Length; i++)
        {
            productoNumero1[i].SetActive(false);
            productoNumero1[i].SetActive(false);
        }
        
    }
    void Activate()
    {
        ProdLadIzq = Random.Range(0, productoNumero1.Length);
        ProdLadDer = Random.Range(0, productoNumero2.Length);
        productoNumero1[ProdLadIzq].transform.position = new Vector3(5f, 0f, 0f);
        productoNumero2[ProdLadDer].transform.position = new Vector3(-9f, 0f, 0f);
        productoNumero1[ProdLadIzq].SetActive(true);
        productoNumero1[ProdLadDer].SetActive(true);

    }
}
