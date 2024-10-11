using Robust.Shared.Serialization;
using Content.Shared.MassMedia.Systems;

namespace Content.Shared._EstacaoPirata.CartridgeLoader.Cartridges;

[Serializable, NetSerializable]
public sealed class MessengerBoundUserInterfaceState : BoundUserInterfaceState
{
    /*public NewsArticle Article;
    public int TargetNum;
    public int TotalNum;*/
    public bool NotificationOn;

    public MessengerBoundUserInterfaceState(NewsArticle article, int targetNum, int totalNum, bool notificationOn)
    {
        /*Article = article;
        TargetNum = targetNum;
        TotalNum = totalNum;*/
        NotificationOn = notificationOn;
    }
}

[Serializable, NetSerializable]
public sealed class MessengerEmptyBoundUserInterfaceState : BoundUserInterfaceState
{
    public bool NotificationOn;

    public MessengerEmptyBoundUserInterfaceState(bool notificationOn)
    {
        NotificationOn = notificationOn;
    }
}