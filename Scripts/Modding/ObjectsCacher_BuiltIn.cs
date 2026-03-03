using Insthync.DevExtension;

namespace MultiplayerARPG
{
    public static partial class ObjectsCacher
    {
        public static partial void CacheDevExtMethods()
        {
            DevExtUtils.CacheInstanceDevExtMethods(typeof(UIBase), "Show");
            DevExtUtils.CacheInstanceDevExtMethods(typeof(UIBase), "Hide");
            DevExtUtils.CacheInstanceDevExtMethods(typeof(BaseGameEntity), "Awake");
            DevExtUtils.CacheInstanceDevExtMethods(typeof(BaseGameEntity), "OnDestroy");
            DevExtUtils.CacheInstanceDevExtMethods(typeof(GameEntityModel), "SetEffectContainersBySetters");
            DevExtUtils.CacheInstanceDevExtMethods(typeof(BaseCharacterModel), "SetEquipmentContainersBySetters");
            DevExtUtils.CacheInstanceDevExtMethods(typeof(BasePlayerCharacterController), "Awake");
            DevExtUtils.CacheInstanceDevExtMethods(typeof(BasePlayerCharacterController), "OnDestroy");
        }
    }
}
