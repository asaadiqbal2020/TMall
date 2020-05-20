using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUIT : MonoBehaviour
{
  public void doQuit ()
    {
        Debug.Log("The application has been terminated.");
        Application.Quit();
    }
}
