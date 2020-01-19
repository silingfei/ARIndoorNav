﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsUI : MonoBehaviour
{
    public SystemStatePresenter _SystemStatePresenter;
    
    public void StartMarkerDetection()
    {
        _SystemStatePresenter.RequestMarkerTracking();
    }

    public void TestMessage()
    {
        _SystemStatePresenter.TestMessage();
    }

    public void StartStopWallIndicator()
    {
        _SystemStatePresenter.IndicateDetectedWall();
    }
}
