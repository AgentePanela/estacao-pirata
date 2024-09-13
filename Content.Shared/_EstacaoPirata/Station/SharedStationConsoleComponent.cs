using Robust.Shared.Serialization;

namespace Content.Shared._EstacaoPirata.Station
{
    [Virtual]
    public partial class SharedStationConsoleComponent : Component
    {
    }

    //sync
    [Serializable, NetSerializable]
    public sealed class StationConsoleInterfaceState : BoundUserInterfaceState
    {
    }
    
    /* mensagens
    [Serializable, NetSerializable]
    public sealed class StationConsole<mensagem>Message : BoundUserInterfaceMessage { }*/

    [Serializable, NetSerializable]
    public enum StationConsoleUiKey
    {
        Key
    }
}