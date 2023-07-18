using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bootstrap : MonoBehaviour
{
   private PuzzleGenerator _puzzleGenerator;

  



    void Start()
    {
        _puzzleGenerator = new PuzzleGenerator();
       
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyUp(KeyCode.Space))
        {
            GeneratePuzzle();
        }   
    }
    public void GeneratePuzzle()
    {
        Debug.Log("create puzzle");
    }
}
