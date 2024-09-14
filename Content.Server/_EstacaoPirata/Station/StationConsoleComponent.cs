using Content.Server.UserInterface;
using Content.Shared._EstacaoPirata.Station;
using Robust.Shared.Audio;

namespace Content.Server._EstacaoPirata.Station
{
    [RegisterComponent]
    public sealed partial class StationConsoleComponent : SharedStationConsoleComponent
    {
        public float UIUpdateAccumulator = 0f;

        /// <summary>
        /// Fluent ID for the announcement title
        /// If a Fluent ID isn't found, just uses the raw string
        /// </summary>
        [ViewVariables(VVAccess.ReadWrite)]
        [DataField(required: true)]
        public LocId Title = "comms-console-announcement-title-station";

        /// <summary>
        /// Announcement color
        /// </summary>
        [ViewVariables]
        [DataField]
        public Color Color = Color.Gold;

        /// <summary>
        /// Announce sound file path
        /// </summary>
        [DataField]
        public SoundSpecifier Sound = new SoundPathSpecifier("/Audio/Announcements/announce.ogg");
    }
}