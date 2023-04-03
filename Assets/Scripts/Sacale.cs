using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sacale : MonoBehaviour
{
    public GameObject sfere;
    private void Start()
    {
        sfere = GetComponent<GameObject>();
    }
    public void Scale(int v)
    {
        sfere.transform.localScale = Vector3.one * v;
    }

}
