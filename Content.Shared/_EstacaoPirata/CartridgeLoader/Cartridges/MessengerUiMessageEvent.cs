using Robust.Shared.Serialization;
using Content.Shared.CartridgeLoader;

namespace Content.Shared._EstacaoPirata.CartridgeLoader.Cartridges;

[Serializable, NetSerializable]
public sealed class MessengerUiMessageEvent : CartridgeMessageEvent
{
    public readonly MessengerUiAction Action;

    public MessengerUiMessageEvent(MessengerUiAction action)
    {
        Action = action;
    }
}

[Serializable, NetSerializable]
public enum MessengerUiAction
{
    Next,
    Prev,
    NotificationSwitch
}