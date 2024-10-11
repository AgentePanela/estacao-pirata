namespace Content.Server._EstacaoPirata.CartridgeLoader.Cartridges;

[RegisterComponent]
public sealed partial class MessengerCartridgeComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    public int Channel;

    [ViewVariables(VVAccess.ReadWrite), DataField]
    public bool NotificationOn = true;

    [ViewVariables(VVAccess.ReadWrite), DataField]
    public bool Author = true;
}
