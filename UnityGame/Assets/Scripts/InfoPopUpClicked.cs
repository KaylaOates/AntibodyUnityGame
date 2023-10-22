using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPopUpClicked : MonoBehaviour
{

    public GameObject destroyVirus;
    public GameObject destroyPopUp;

    private void OnMouseDown()
    {
        if (destroyVirus != null)
        {
            Destroy(destroyVirus);
        }

        if (destroyPopUp != null)
        {
            Destroy(destroyPopUp);
        }   
    }
}