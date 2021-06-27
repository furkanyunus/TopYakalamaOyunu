using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    public GameObject kutuKlonu;
    private GameObject klonKontrolu;
    // Start is called before the first frame update
    void Start()
    {
        klonKontrolu = Instantiate(kutuKlonu, new Vector3(0.02f, 0.47f, -7.5f), transform.rotation);
        klonKontrolu.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
