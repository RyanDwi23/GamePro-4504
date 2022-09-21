using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObject : MonoBehaviour
{
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1,0,0);
        kekanan = new Vector3(-1,0,0);
        kekanan = new Vector3(0,1,0);
        kekanan = new Vector3(0,-1,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (kekanan * 2 * Time.deltaTime);
        transform.position = transform.position + (kekiri * 2 * Time.deltaTime);
        transform.position = transform.position + (keatas * 2 * Time.deltaTime);
        transform.position = transform.position + (kebawah * 2 * Time.deltaTime);
    }
}
