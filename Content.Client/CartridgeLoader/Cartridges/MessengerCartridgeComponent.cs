namespace Content.Client.CartridgeLoader.Cartridges;

[RegisterComponent]
public sealed partial class MessengerCartridgeComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    public int ArticleNumber;

    [ViewVariables(VVAccess.ReadWrite), DataField]
    public bool NotificationOn = true;
}
