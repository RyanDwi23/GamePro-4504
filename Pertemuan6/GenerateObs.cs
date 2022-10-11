using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rocks;
    int score = 0;
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
    }
    void CreateObstacle() {
        
        Instantiate(rocks);
        score++;
    }
    //void OnGUI() {
        //score = 0;
        //GUI().color = Color.black;
        //GUILayout.Label("Score : " + score.ToString());
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
