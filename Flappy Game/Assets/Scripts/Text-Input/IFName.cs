﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFName : MonoBehaviour
{
    public static string input;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
}
