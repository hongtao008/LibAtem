namespace LibAtem.Commands.Settings.Multiview
{
    [CommandName("VuMS")]
    public class MultiviewWindowVuMeterSetCommand : ICommand
    {
        public uint MultiviewIndex { get; set; }
        public uint WindowIndex { get; set; }
        public bool VuEnabled { get; set; }

        public void Serialize(CommandBuilder cmd)
        {
            cmd.AddUInt8(MultiviewIndex);
            cmd.AddUInt8(WindowIndex);
            cmd.AddBoolArray(VuEnabled);
        }

        public void Deserialize(ParsedCommand cmd)
        {
            MultiviewIndex = cmd.GetUInt8();
            WindowIndex = cmd.GetUInt8();
            VuEnabled = cmd.GetBoolArray()[0];
        }
    }
}