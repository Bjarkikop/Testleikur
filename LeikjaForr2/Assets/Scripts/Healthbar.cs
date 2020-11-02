using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
    //slider fyrir healthbarinn
    public Slider slider;

    //fall sem lætur max health
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    //fall sem lætur nýtt health
    public void SetHealth(int health)
    {
        slider.value = health;
    }
    
    

}
