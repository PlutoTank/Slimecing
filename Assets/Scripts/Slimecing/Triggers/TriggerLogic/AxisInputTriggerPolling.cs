﻿using UnityEngine;
using UnityEngine.InputSystem;

namespace Slimecing.Triggers.TriggerLogic
{
    [CreateAssetMenu(fileName = "AxisInputTrigger ", menuName = "Triggers/InputTriggers/AxisInputTrigger ")]
    public class AxisInputTrigger : TriggerInput
    {
        protected override void TriggerStarted(GameObject player, InputAction.CallbackContext ctx)
        {
            
        }

        protected override void TriggerPerformed(GameObject player, InputAction.CallbackContext ctx)
        {
            currentTriggerState = TriggerState.Performed;
            inputContext = ctx;
            OnTriggerStateChange(new TriggerPackage(TriggerState.Performed, player, ctx));
        }

        protected override void TriggerCanceled(GameObject player, InputAction.CallbackContext ctx)
        {
            currentTriggerState = TriggerState.Canceled;
            inputContext = ctx;
            OnTriggerStateChange(new TriggerPackage(TriggerState.Canceled, player, ctx));
        }
    }
}