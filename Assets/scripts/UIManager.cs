using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public GameObject PlayButton;
    public GameObject PauseButton;
    public GameObject MuteButton;
    public GameObject UnMuteButton;
    public GameObject NextButton;
    public GameObject PrevButton;
    public GameObject VideoManager;
    // Use this for initialization
    void Start () {
        PlayButton.SetActive(true);
        PauseButton.SetActive(false);
        MuteButton.SetActive(true);
        UnMuteButton.SetActive(false);
        PrevButton.SetActive(true);
        NextButton.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Play()
    {
        PlayButton.SetActive(false);
        PauseButton.SetActive(true);
        VideoManager.SendMessage("Play the video", null, SendMessageOptions.DontRequireReceiver);
    }
    public void Pause()
    {
        PlayButton.SetActive(true);
        PauseButton.SetActive(false);
        VideoManager.SendMessage("Pause the video", null, SendMessageOptions.DontRequireReceiver);
    }
    public void Mute()
    {
        MuteButton.SetActive(false);
        UnMuteButton.SetActive(true);
        VideoManager.SendMessage("Mute the video", null, SendMessageOptions.DontRequireReceiver);
    }
    public void UnMute()
    {
        UnMuteButton.SetActive(false);
        MuteButton.SetActive(true);
        VideoManager.SendMessage("UnMute the video", null, SendMessageOptions.DontRequireReceiver);
    }
    public void Next()
    {
        VideoManager.SendMessage("Play the next video", null, SendMessageOptions.DontRequireReceiver);
    }
    public void Prev()
    {
        VideoManager.SendMessage("Play the previous video", null, SendMessageOptions.DontRequireReceiver);
    }
}
