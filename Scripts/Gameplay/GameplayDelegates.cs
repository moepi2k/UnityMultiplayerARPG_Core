using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace MultiplayerARPG
{
    public delegate void IsUpdateEntityComponentsDelegate(
        BaseGameEntity target,
        bool isUpdate);

    public delegate void NetworkDestroyDelegate(
        BaseGameEntity target,
        byte reasons);

    public delegate void ReceiveDamageDelegate(
        DamageableEntity target,
        HitBoxPosition position,
        Vector3 fromPosition,
        EntityInfo instigator,
        Dictionary<DamageElement, MinMaxFloat> damageAmounts,
        CharacterItem weapon,
        BaseSkill skill,
        int skillLevel);

    public delegate void ReceivedDamageDelegate(
        DamageableEntity target,
        HitBoxPosition position,
        Vector3 fromPosition,
        EntityInfo instigator,
        CombatAmountType combatAmountType,
        int totalDamage,
        CharacterItem weapon,
        BaseSkill skill,
        int skillLevel,
        CharacterBuff buff,
        bool isDamageOverTime);

    public delegate void NotifyEnemySpottedDelegate(
        BaseCharacterEntity target,
        BaseCharacterEntity enemy);

    public delegate void NotifyEnemySpottedByAllyDelegate(
        BaseCharacterEntity target,
        BaseCharacterEntity ally,
        BaseCharacterEntity enemy);

    public delegate void AppliedRecoveryAmountDelegate(
        BaseCharacterEntity target,
        EntityInfo causer,
        int amount);

    public delegate void AttackRoutineDelegate(
        BaseGameEntity target,
        bool isLeftHand,
        CharacterItem weapon,
        int simulateSeed,
        byte triggerIndex,
        DamageInfo damageInfo,
        List<Dictionary<DamageElement, MinMaxFloat>> damageAmounts,
        AimPosition aimPosition);

    public delegate void UseSkillRoutineDelegate(
        BaseGameEntity target,
        BaseSkill skill,
        int level,
        bool isLeftHand,
        CharacterItem weapon,
        int simulateSeed,
        byte triggerIndex,
        List<Dictionary<DamageElement, MinMaxFloat>> damageAmounts,
        uint targetObjectId,
        AimPosition aimPosition);

    public delegate void LaunchDamageEntityDelegate(
        BaseGameEntity target,
        bool isLeftHand,
        CharacterItem weapon,
        int simulateSeed,
        byte triggerIndex,
        byte spreadIndex,
        List<Dictionary<DamageElement, MinMaxFloat>> damageAmounts,
        BaseSkill skill,
        int skillLevel,
        AimPosition aimPosition);

    public delegate void ApplyBuffDelegate(
        BaseGameEntity target,
        CharacterBuff buff);

    public delegate void RemoveBuffDelegate(
        BaseGameEntity target,
        CharacterBuff buff,
        BuffRemoveReasons reason);

    public delegate void CharacterStatsDelegate(
        ref CharacterStats a,
        CharacterStats b);

    public delegate void CharacterStatsAndNumberDelegate(
        ref CharacterStats a,
        float b);

    public delegate void RandomCharacterStatsDelegate(
        System.Random random,
        ItemRandomBonus randomBonus,
        bool isRateStats,
        ref CharacterStats stats,
        ref int appliedAmount);

    public delegate void CanAttackDelegate(
        BaseGameEntity target,
        ref bool canAttack);

    public delegate void CanUseSkillDelegate(
        BaseGameEntity target,
        ref bool canUseSkill);

    public delegate void CanReloadDelegate(
        BaseGameEntity target,
        ref bool canReload);

    public delegate void CanMoveDelegate(
        BaseGameEntity target,
        ref bool canMove);

    public delegate void CanSprintDelegate(
        BaseGameEntity target,
        ref bool canSprint);

    public delegate void CanWalkDelegate(
        BaseGameEntity target,
        ref bool canWalk);

    public delegate void CanCrouchDelegate(
        BaseGameEntity target,
        ref bool canCrouch);

    public delegate void CanCrawlDelegate(
        BaseGameEntity target,
        ref bool canCrawl);

    public delegate void CanJumpDelegate(
        BaseGameEntity target,
        ref bool canJump);

    public delegate void CanDashDelegate(
        BaseGameEntity target,
        ref bool canDash);

    public delegate void CanTurnDelegate(
        BaseGameEntity target,
        ref bool canTurn);

    public delegate void JumpForceAppliedDelegate(
        BaseGameEntity target,
        float verticalVelocity);

    public delegate void UpdateEquipmentModelsDelegate(
        BaseCharacterModel target,
        CancellationTokenSource cancellationTokenSource,
        Dictionary<string, EquipmentModel> showingModels,
        Dictionary<string, EquipmentModel> storingModels,
        HashSet<string> unequippingSockets);

    public delegate void OnEquipmentModelInstantiateDelegate(
        EquipmentModel target,
        GameObject instantiatedObject,
        BaseEquipmentEntity instantiatedEntity,
        EquipmentInstantiatedObjectGroup instantiatedObjectGroup,
        EquipmentContainer equipmentContainer);

    public delegate void OnCharacterEquipmentModelInstantiateDelegate(
        BaseCharacterModel target,
        EquipmentModel model,
        GameObject instantiatedObject,
        BaseEquipmentEntity instantiatedEntity,
        EquipmentInstantiatedObjectGroup instantiatedObjectGroup,
        EquipmentContainer equipmentContainer);

    public delegate void CalculatedItemBuffDelegate(
        CalculatedItemBuff calculatedItemBuff);

    public delegate void CalculatedBuffDelegate(
        CalculatedBuff calculatedBuff);

    public delegate void OnDropItemDelegate(
        BaseItem item,
        int level,
        int amount);

    public delegate void GameEntityDelegate(
        BaseGameEntity target);

    public delegate void GameEntityInt8ChangeDelegate(
        BaseGameEntity target,
        sbyte oldValue,
        sbyte newValue);

    public delegate void GameEntityInt16ChangeDelegate(
        BaseGameEntity target,
        short oldValue,
        short newValue);

    public delegate void GameEntityInt32ChangeDelegate(
        BaseGameEntity target,
        int oldValue,
        int newValue);

    public delegate void GameEntityInt64ChangeDelegate(
        BaseGameEntity target,
        long oldValue,
        long newValue);

    public delegate void GameEntityUInt8ChangeDelegate(
        BaseGameEntity target,
        byte oldValue,
        byte newValue);

    public delegate void GameEntityUInt16ChangeDelegate(
        BaseGameEntity target,
        ushort oldValue,
        ushort newValue);

    public delegate void GameEntityUInt32ChangeDelegate(
        BaseGameEntity target,
        uint oldValue,
        uint newValue);

    public delegate void GameEntityUInt64ChangeDelegate(
        BaseGameEntity target,
        ulong oldValue,
        ulong newValue);

    public delegate void GameEntitySingleChangeDelegate(
        BaseGameEntity target,
        float oldValue,
        float newValue);

    public delegate void GameEntityDoubleChangeDelegate(
        BaseGameEntity target,
        double oldValue,
        double newValue);

    public delegate void GameEntityBooleanChangeDelegate(
        BaseGameEntity target,
        bool oldValue,
        bool newValue);

    public delegate void GameEntityStringChangeDelegate(
        BaseGameEntity target,
        string oldValue,
        string newValue);

    public delegate void GameEntityVector3ChangeDelegate(
        BaseGameEntity target,
        Vector3 oldValue,
        Vector3 newValue);

    public delegate void GameEntityAimPositionChangeDelegate(
        BaseGameEntity target,
        AimPosition oldValue,
        AimPosition newValue);

    public delegate void GameEntitySummonerChangeDelegate(
        BaseGameEntity target,
        CharacterSummoner oldValue,
        CharacterSummoner newValue);
}
