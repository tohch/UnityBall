using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthImage;
    public int decreaseCount;
    public int healthCount = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    void FixedUpdate()
    {
        if (healthCount < 100)
        {
            healthCount++;
        }
        UpdateUi();
    }
    public void DecreaseHealth()
    {
        if (healthCount <= 0)
        {
            return;
        }
        healthCount -= decreaseCount;
    }
    private void UpdateUi()
    {
        healthImage.fillAmount = healthCount / 100f;
    }
}
