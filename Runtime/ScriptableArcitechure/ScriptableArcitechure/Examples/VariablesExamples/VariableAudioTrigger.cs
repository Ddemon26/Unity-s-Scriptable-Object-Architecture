﻿using UnityEngine;

namespace ScriptableArchitect.Variables
{
    /// <summary>
    /// This class is used to trigger an audio source when a float variable's value falls below a certain threshold.
    /// </summary>
    [AddComponentMenu("Scriptable Architect/Variables/AudioSetters/Variable Audio Trigger")]
    [HelpURL("https://www.youtube.com/watch?v=raQ3iHhE_Kk&t=2132s")]
    public class VariableAudioTrigger : MonoBehaviour
    {
        /// <summary>
        /// The AudioSource that will be triggered.
        /// </summary>
        [Tooltip("The AudioSource that will be triggered.")]
        public AudioSource AudioSource;

        /// <summary>
        /// The FloatVariable that will be monitored.
        /// </summary>
        [Tooltip("The FloatVariable that will be monitored.")]
        public FloatVariable Variable;

        /// <summary>
        /// The threshold below which the AudioSource will be triggered.
        /// </summary>
        [Tooltip("The threshold below which the AudioSource will be triggered.")]
        public FloatReference LowThreshold;

        private bool isPlaying;

        /// <summary>
        /// Update is called every frame, if the MonoBehaviour is enabled.
        /// If the value of the FloatVariable is below the LowThreshold, it plays the AudioSource if it is not already playing.
        /// If the value of the FloatVariable is not below the LowThreshold, it stops the AudioSource if it is playing.
        /// </summary>
        private void Update()
        {
            if (Variable.Value < LowThreshold)
            {
                if (!isPlaying)
                {
                    AudioSource.Play();
                    isPlaying = true;
                }
            }
            else
            {
                if (isPlaying)
                {
                    AudioSource.Stop();
                    isPlaying = false;
                }
            }
        }
    }
}