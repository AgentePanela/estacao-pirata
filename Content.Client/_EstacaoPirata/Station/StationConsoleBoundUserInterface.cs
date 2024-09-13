using Content.Shared.CCVar;
using Content.Shared.Chat;
using Content.Shared.Communications;
using Robust.Shared.Configuration;
using Robust.Shared.Timing;

namespace Content.Client._EstacaoPirata.Station
{
    public sealed class StationConsoleBoundUserInterface : BoundUserInterface
    {
        [ViewVariables]
        private StationConsoleWindow? _window;

        public StationConsoleBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
        {
        }
        protected override void Open()
        {
            base.Open();

            _window = new StationConsoleWindow
            {
                //Title = Loc.GetString("medipen-refiller-bound-user-interface-title"),
                Title = "Station Console"
            };

            var component = EntMan.GetComponent<StationConsoleComponent>(Owner);

            _window.OpenCentered();
            _window.OnClose += Close;
            /*_window.OnMedipenButtonPressed += id => SendMessage(new StationConsoleActivateMessage(id));
            _window.OnTransferButtonPressed += args => SendMessage(new StationConsoleTransferReagentMessage(args.Id, args.Value, args.IsBuffer));
            _window.InputEjectButton.OnPressed += _ => SendMessage(new ItemSlotButtonPressedEvent(component.InputSlotName));
            _window.MedipenEjectButton.OnPressed += _ => SendMessage(new ItemSlotButtonPressedEvent(component.MedipenSlotName));*/
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                _window?.Dispose();
            }
        }
}