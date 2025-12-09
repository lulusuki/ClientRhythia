using Godot;

public interface ISettingsItem
{
    Variant GetVariant();

    void SetVariant(Variant variant);

    bool SaveToDisk { get; }
}
