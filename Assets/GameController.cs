﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 

public class GameController : MonoBehaviour
{


   //{
    
//}
   [Header("Cube Object")]
   public GameObject currentCube;
   [Header("Last Cube Object")]
   public Text text;
   [Header("Current Level")]
   public int Level;
   [Header("Boolean")]
   public bool Done;



   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void Newblock()
{
    if(lastCube != null)
    {
        currentCube.transform.position = new Vector3(Mathf.Round(currentCube.transform.position.x),
        currentCube.transform.position.y,
        Mathf.Round(currentCube.transform.position.z));
        currentCube.transform.localScale = new Vector3(lastCube.transform.localScale.x - Mathf.Abs(currentCube.transform.position.x - lastCube.transform.position.x),
                                 lastCube.transform.localScale.y,
                                 lastCube.transform.localScale.z - Mathf.Abs(currentCube.transform.position.z - lastCube.transform.position.z));
                                 currentCube.transform.position = Vector3.Lerp(currentCube.transform.position, lastCube.transform.position, 0.5) + Vector3.up * 5f;
        
    }
}

}
