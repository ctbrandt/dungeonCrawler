using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
        // Start is called before the first frame update
    public GameObject currMenu;
    public GameObject altMenu;
    public void HelpMenuDisplay(){
        currMenu.SetActive(false);
        altMenu.SetActive(true);
    }
}
