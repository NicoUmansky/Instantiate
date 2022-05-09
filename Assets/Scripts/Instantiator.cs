using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject ObjectToClone;
    public int canti;
    public void CloneObject()
    {
        int i = 0;
        while (i < canti)
        {
            Instantiate(ObjectToClone);
            i++;
        }
   
    }
}
