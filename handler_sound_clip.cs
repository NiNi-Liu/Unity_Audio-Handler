using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handler_sound_clip : MonoBehaviour
{
    AudioHandler aHandler;
    [SerializeField]
    AudioClip m_clip;

    void Start()
    {
        aHandler = GameObject.Find("Audio_Handler").GetComponent<AudioHandler>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySound(m_clip);
        }
    }


    void PlaySound(AudioClip aClip)
    {
        aHandler.PlayAudio(aClip);
    }
}
