using LiteNetLib.Utils;

namespace MultiplayerARPG
{
    public static class EntityMovementDataBuffers
    {
        internal static readonly NetDataWriter StateMessageWriter = new NetDataWriter();
        internal static readonly NetDataWriter StateDataWriter = new NetDataWriter();
    }
}
