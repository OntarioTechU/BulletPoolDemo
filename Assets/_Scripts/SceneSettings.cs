﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneSettings", menuName = "Game/Scene/Settings")]
[System.Serializable]
public class SceneSettings : ScriptableObject
{
    [Header("Scene  Settings")]
    public Scene scene;
    public SoundClip activeSoundClip;

    [Header("ScoreBoard  Settings")]
    public bool scoreLabelEnabled;
    public bool livesLabelEnabled;
    public bool highScoreLabelEnabled;

    [Header("Scene Label  Settings")]
    public bool startLabelSetActive;
    public bool endLabelSetActive;

    [Header("Scene Button  Settings")]
    public bool startButtonActive;
    public bool restartButtonActive;
}
