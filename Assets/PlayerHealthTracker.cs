using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthTracker : MonoBehaviour
{

    public Image image;
    public HealthComponent healthComponent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        image.fillAmount = healthComponent.health / healthComponent.maxHealth;
    }
}
