using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using System.Text;
public class readjust : MonoBehaviour
{
    public string txtFile = "test";
    string txtContents;
    public string joow ;
    private string ow = "kk";
    public TextAsset txtAssets;


    private float number;

    private void Start()
    {
        txtAssets = (TextAsset)Resources.Load(txtFile);
        txtContents = txtAssets.text;

    }

    void Update()
    {

        if (joow == ow)
        {
            Debug.Log("wedidit");

        }


        if (joow == "50")
        {
            number= float.Parse(joow);

        }


        if (number == 50)
        {
            Debug.Log(joow);
        }



    }



}
