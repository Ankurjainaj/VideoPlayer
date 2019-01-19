using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour {
    public VideoClip[] VideoClips;
    public int CurrentVideo = 0;
    VideoPlayer VideoPlayer;
    AudioSource AudioSource;
    bool IsPlaying = false;
    // Use this for initialization
    void Start () {
        VideoPlayer = GetComponent<VideoPlayer>();
        AudioSource = GetComponent<AudioSource>();
        VideoPlayer.clip = VideoClips[CurrentVideo];
        VideoPlayer.SetTargetAudioSource(0, AudioSource);
    }
	
	public void Play()
    {
        VideoPlayer.Play();
        AudioSource.Play();
        IsPlaying = true;
    }
    public void Pause()
    {
        AudioSource.Pause();
        VideoPlayer.Pause();
        IsPlaying = false;

    }
    public void Next()
    {
        if (CurrentVideo == VideoClips.Length - 1)
            CurrentVideo = 0;
        else
            CurrentVideo++;
        VideoPlayer.clip = VideoClips[CurrentVideo];
        VideoPlayer.SetTargetAudioSource(0, AudioSource);
        if (IsPlaying)
            Play();
    }
    public void Prev()
    {
        if (CurrentVideo == 0)
            CurrentVideo = VideoClips.Length - 1;
        else
            CurrentVideo--;

        VideoPlayer.clip = VideoClips[CurrentVideo];
        VideoPlayer.SetTargetAudioSource(0, AudioSource);
        if (IsPlaying)
            Play();
    }
    public void Mute()
    {
        AudioSource.mute = true;
    }
    public void UnMute()
    {
        AudioSource.mute = false;
    }
}
