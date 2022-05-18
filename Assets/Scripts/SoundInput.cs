using System.Collections;
using System.Collections.Generic;
using FrostweepGames.Plugins.Native;
using FrostweepGames.VoicePro;
using UnityEngine;

public class SoundInput : MonoBehaviour
{
    public Recorder recorder;

    public Listener listener;

    public bool isRecording;


    // Start is called before the first frame update
    void Start()
    {
        refreshAndDetectMics();
        Debug.Log("!!! README !!!\n In this exact order:\n1. Press T to refresh and detect mics\n2. Press R for push to talk\nIf done incorrectly no sound will be transmitted");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && !isRecording)
        {
            StartRecord();
            isRecording = true;
            Debug.Log("R pressed");
        }
        else if(Input.GetKeyUp(KeyCode.R) && isRecording)
        {
            StopRecord();
            isRecording = false;
        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            refreshAndDetectMics();   
        }
    }

    private void refreshAndDetectMics()
    {
        recorder.RefreshMicrophones();
        Debug.Log("Refreshed mics");

        if (CustomMicrophone.HasConnectedMicrophoneDevices())
        {
            recorder.SetMicrophone(CustomMicrophone.devices[0]);
            Debug.Log("Set microphone to " + CustomMicrophone.devices[0]);
        }
    }

    public void StartRecord()
    {
        recorder.StartRecord();
    }

    public void StopRecord()
    {
        recorder.StopRecord();
    }
}
