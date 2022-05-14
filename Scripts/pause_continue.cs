using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause_continue : MonoBehaviour
{
    public bool click = false;
   public void PauseOrContinue()
    {
          if (click == true)
          {
              Time.timeScale = 0f;
            click = !click;
        } else
          {
              Time.timeScale = 1f;
            click = !click;
        } 
    }
}
