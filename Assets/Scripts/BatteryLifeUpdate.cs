using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryLifeUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    public float batteryTimer;
    public Text batteryUIText;
    public bool isFlashlightAvailable = true;
    public Light flashlight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        batteryTimer -= Time.deltaTime;
        batteryUIText.text = batteryTimer.ToString("0") + "%";
        if( batteryTimer <= 0 ) {
            this.enabled = false;
            isFlashlightAvailable = false;
            flashlight.enabled = false;
        }
        delayTimer();
    }

    IEnumerator delayTimer(){
        yield return new WaitForSeconds(3.0f);
    }
}
