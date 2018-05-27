using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOn : MonoBehaviour {

    [Header("Object Text Information")]
    public string objectName;
    public string objectCost;

    [TextArea]
    public string objectInfo;

    [Header("Display the Information")]
    public GameObject toolTipWindow;
    public Text displayName;
    public Text displayCost;
    public Text displayInfo;

    void OnMouseEnter()
    {
        toolTipWindow.SetActive(true);

        if(toolTipWindow != null)
        {
            displayName.text = objectName;
            displayInfo.text = objectInfo;
            displayCost.text += Upgrade.instance.cost;
        }
        
    }

    void OnMouseExit()
    {
        toolTipWindow.SetActive(false);

    }


   
}
