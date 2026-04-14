namespace MultiplayerARPG
{
    public interface ICharacterChargeComponent
    {
        bool IsCharging { get; }
        bool WillDoActionWhenStopCharging { get; }
        bool IsSkipMovementValidationWhileCharging { get; }
        bool IsUseRootMotionWhileCharging { get; }
        float MoveSpeedRateWhileCharging { get; }
        MovementRestriction MovementRestrictionWhileCharging { get; }
        /// <summary>
        /// The time when the charge started (Time.unscaledTime).
        /// Used for server-side validation of charge duration.
        /// </summary>
        float ChargeStartTime { get; }
        /// <summary>
        /// The required duration for the charge to complete.
        /// Used for server-side validation of charge duration.
        /// </summary>
        float ChargeDuration { get; }

        void ClearChargeStates();
        void StartCharge(bool isLeftHand);
        void StopCharge();
    }
}
