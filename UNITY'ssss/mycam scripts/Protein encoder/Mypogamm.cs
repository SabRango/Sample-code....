using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Threading;
using System.Linq;
using System;
using System.IO;

public class Mypogamm : MonoBehaviour
{
    [SerializeField]
    GameObject spawwnCarbon;

    [SerializeField]
    GameObject spawwnNitrogen;


    [SerializeField]
    GameObject spawwnOxigen;
    public Vector3 posSpaw;
    private string atommm = "atom";
    private string carbb = "c";
    private string Nitt = "n";
    private string Oxii = "o";

    private string afterconv;
    private int pop=0;
    bool popdooo = true;
    private float x, y, z =0;

    public int idfirst = 0;
    private bool IDgoo = true;



    public string pathhh = @"C:\Users\Bahodir\Desktop\pdbunity.txt";
    
    void Update()
    {
        List<string> pdbb = File.ReadLines(pathhh).ToList();




        string afterconv = pdbb[idfirst];
        Debug.Log(pdbb.Count);
        

        if (IDgoo)
        {
            idfirst++;
            if (idfirst == pdbb.Count) { idfirst -= 3; }
        }
        Debug.Log(afterconv);
        string[] ar_ = afterconv.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

       
        foreach (string word in ar_)
        {
            
            Debug.Log("WORD: " + word);

        }

      
        if (ar_[0] == atommm)
        {
            float x = float.Parse(ar_[1]);
            float y = float.Parse(ar_[2]);
            float z = float.Parse(ar_[3]);
            posSpaw = Vector3.zero;
            posSpaw += Vector3.right * x;
            posSpaw += Vector3.up * y;
            posSpaw += Vector3.forward * z;

            


            Debug.Log("firt is atmmmmmmmm");
            if (ar_[4] == carbb)
            {
                Instantiate(spawwnCarbon, posSpaw, Quaternion.identity);
                Debug.Log("mynameiscarbon");
            }
            if (ar_[4] == Nitt)
            {
                Instantiate(spawwnNitrogen, posSpaw, Quaternion.identity);

                Debug.Log("mynameisnittttooo");
            }
            if (ar_[4] == Oxii)
            {
                Instantiate(spawwnOxigen, posSpaw, Quaternion.identity);

                Debug.Log("mynameisnittttooo");
            }



        }
    }   
}

