using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Dictionary<string, int> inventory = new Dictionary<string, int>();
    public Text keyCountUI;


    public void AddItem(string item) {
        int currItemCount = 0;
        if( this.inventory.TryGetValue(item, out currItemCount)) {
            this.inventory[item] = currItemCount + 1;
        } else {
            this.inventory.Add(item, 1);
        }
        UpdateUI();
    }

    public void RemoveItem(string item) {
        int currItemCount = 0;
        if( this.inventory.TryGetValue(item, out currItemCount)) {
            if( currItemCount > 1) {
                this.inventory[item] = currItemCount - 1;
            } else {
                this.inventory.Remove(item);
            }
        }
        UpdateUI();
    }

    void UpdateUI(){
        this.inventory.TryGetValue("key", out int keyCount);
        keyCountUI.text = (keyCount > 0) ? keyCount.ToString() : "0";
        Debug.Log(keyCount);
    }

    public bool HasDoorReqs(int goldKey){
        if( this.inventory.TryGetValue("key", out int keyCount) ){
            return ( keyCount >= goldKey);
        } else {
            return false;
        }
    }
}
