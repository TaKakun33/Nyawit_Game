using UnityEngine;

public class SoundGameScripts : MonoBehaviour
{
    public AudioSource myAudioSource;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f)
        {
            myAudioSource.mute = true;
        } else
        {
            myAudioSource.mute = false;
        }
    }
}
