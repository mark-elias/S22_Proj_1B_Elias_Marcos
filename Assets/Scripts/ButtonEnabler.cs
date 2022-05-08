using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnabler : MonoBehaviour
{

    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);

        Debug.Log("button set to Unavailable");
    }

    // Update is called once per frame
    void Update()
    {
        if (PersistentManagerScript.Instance.BUTTON_AVAILABLE == true)
        {
            button.SetActive(true);
        }
    }

    public void Button_Enabler()
    {
        
        if (PersistentManagerScript.Instance.BUTTON_AVAILABLE == true)
        {
            button.SetActive(true);
        }
        
        
     
    }
}
