using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using System.IO;

public class Outshipp : MonoBehaviour

{
    [SerializeField]
GameObject spawwnCarbon;

[SerializeField]
GameObject spawwnNitrogen;


[SerializeField]
GameObject spawwnOxigen;


[SerializeField]
GameObject spawwnSulfur;
private Vector3 posSpaw;
private string atommm = "ATOM";
private string carbb = "C";
private string Nitt = "N";
private string Oxii = "O";
private string Sulf = "S";


public int idfirst = 0;
private bool IDgoo = true;



public string pathhh = @"C:\Users\Bahodir\Desktop\realll.txt";



private void Update()
{
    if (IDgoo)
    {
        nomoo();
    }

}
void nomoo()
{
    List<string> pdbb = File.ReadLines(pathhh).ToList();




    string afterconv = pdbb[idfirst];


    if (IDgoo)
    {
        idfirst++;
        if (idfirst == pdbb.Count) { IDgoo = false; }
    }

        string ar_ = afterconv;

        
        Debug.Log(ar_.Length);

    if (ar_.Substring(0,3) == atommm)
    {

        int arinttt = 77;
            float x = float.Parse(ar_.Substring(32, 37));
            float y = float.Parse(ar_.Substring(40, 45));
            float z = float.Parse(ar_.Substring(48, 53));
        posSpaw = Vector3.zero;
        posSpaw += Vector3.right * x;
        posSpaw += Vector3.up * y;
        posSpaw += Vector3.forward * z;




        if (ar_.Substring(77,78) == carbb)
        {
            Instantiate(spawwnCarbon, posSpaw, Quaternion.identity);
        }
        if (ar_.Substring(77, 78) == Nitt)
        {
            Instantiate(spawwnNitrogen, posSpaw, Quaternion.identity);

            
        }
        if (ar_.Substring(77, 78) == Oxii)
        {
            Instantiate(spawwnOxigen, posSpaw, Quaternion.identity);

            
        }
        if (ar_.Substring(77, 78) == Sulf)
        {
            Instantiate(spawwnSulfur, posSpaw, Quaternion.identity);

        }



    }
}
}