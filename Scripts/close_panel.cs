using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_panel : MonoBehaviour
{
    public GameObject panel;
    public void closePanel()
    {
        panel.SetActive(false);
    }
}
