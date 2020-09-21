﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
using Image = UnityEngine.Experimental.UIElements.Image;


public class UpdateBar : MonoBehaviour
{
    private Image BarImage;
    public FloatData FillNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        BarImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Image.fillAmount = FillNumber.Value;
    }
}
