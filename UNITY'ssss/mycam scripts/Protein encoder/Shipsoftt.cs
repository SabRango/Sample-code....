using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Threading;
using System.Linq;
using System;
using System.IO;

public class Shipsoftt : MonoBehaviour
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

    private string afterconv;
    private int pop = 0;
    bool popdooo = true;
    private float x, y, z = 0;

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
       /* Debug.Log(pdbb.Count);*/


        if (IDgoo)
        {
            idfirst++;
            if (idfirst == pdbb.Count) { IDgoo=false; }
        }
/*        Debug.Log(afterconv);
*/        string[] ar_ = afterconv.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);


        /*foreach (string word in ar_)
        {

            Debug.Log("1111WORD: " + word);

        }*/
        Debug.Log(ar_.Length);

        if (ar_[0] == atommm)
        {

            int arinttt = 0;
            arinttt += ar_.Length-1;
            float x = float.Parse(ar_[6]);
            float y = float.Parse(ar_[7]);
            float z = float.Parse(ar_[8]);
            posSpaw = Vector3.zero;
            posSpaw += Vector3.right * x;
            posSpaw += Vector3.up * y;
            posSpaw += Vector3.forward * z;




            /*Debug.Log("2222firt is atmmmmmmmm");*/
            if (ar_[arinttt] == carbb)
            {
                Instantiate(spawwnCarbon, posSpaw, Quaternion.identity);
               /* Debug.Log("3333mynameiscarbon");*/
            }
            if (ar_[arinttt] == Nitt)
            {
                Instantiate(spawwnNitrogen, posSpaw, Quaternion.identity);

/*                Debug.Log("44444mynameisnittttooo");
*/            }
            if (ar_[arinttt] == Oxii)
            {
                Instantiate(spawwnOxigen, posSpaw, Quaternion.identity);

/*                Debug.Log("55555mynameisnittttooo");
*/            }
            if (ar_[arinttt] == Sulf)
            {
                Instantiate(spawwnSulfur, posSpaw, Quaternion.identity);

/*                Debug.Log("66666mynameisnittttooo");
*/            }



        }
    }
}
