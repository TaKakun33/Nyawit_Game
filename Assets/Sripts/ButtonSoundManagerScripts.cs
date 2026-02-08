using UnityEngine;

public class ButtonSoundManagerScripts : MonoBehaviour
{
public AudioSource audioSource; 
    public AudioClip clickSound;    

    public void PlayClickSound()
    {
        audioSource.PlayOneShot(clickSound);
    }
}
