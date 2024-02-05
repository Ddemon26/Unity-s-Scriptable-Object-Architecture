﻿using UnityEngine;
using UnityEngine.UI;

namespace ScriptableArchitect.Variables
{
    /// <summary>
    /// This class is used to set the value of a Slider component with the value of a FloatVariable.
    /// It executes in both edit and play modes.
    /// </summary>
    [ExecuteInEditMode]
    public class SliderSetter : MonoBehaviour
    {
        /// <summary>
        /// The Slider component whose value will be set.
        /// </summary>
        public Slider Slider;

        /// <summary>
        /// The FloatVariable whose value will be used to set the Slider's value.
        /// </summary>
        public FloatVariable Variable;

        /// <summary>
        /// Update is called every frame, if the MonoBehaviour is enabled.
        /// It sets the value of the Slider to the value of the FloatVariable.
        /// </summary>
        private void Update()
        {
            if (Slider != null && Variable != null)
                Slider.value = Variable.Value;
        }
    }
}