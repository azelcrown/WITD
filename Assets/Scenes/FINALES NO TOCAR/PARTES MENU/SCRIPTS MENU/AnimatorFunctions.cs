using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorFunctions : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    public bool disableOnce;

    public void PlaySound(AudioClip whichSound)
    {
        if (whichSound == null)
        {
            Debug.LogError("AudioClip is null. Please assign a valid AudioClip.");
            return;
        }

        if (!disableOnce)
        {
            if (menuButtonController != null && menuButtonController.audioSource != null)
            {
                menuButtonController.audioSource.PlayOneShot(whichSound);
            }
            else
            {
                Debug.LogError("menuButtonController or menuButtonController.audioSource is not assigned.");
            }
        }
        else
        {
            disableOnce = false;
        }
    }
}