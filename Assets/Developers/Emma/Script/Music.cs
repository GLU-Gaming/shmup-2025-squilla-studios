using UnityEngine;
using UnityEngine.Audio;


public class Music : MonoBehaviour
{
    private bool isLooping = false;
    [SerializeField]private AudioSource begin;
    [SerializeField]private AudioSource loop;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (isLooping)
            return;
        if (!begin.isPlaying)
        {
            isLooping = true;
            loop.Play();
        }
       
    }
}
