using System.Collections.Generic;
using Godot;

public class SettingsList<[MustBeVariant] T>
{
    public SettingsList(T value)
    {
        SelectedValue = value;
        DefaultValue = value;
        Values.Add(value);
    }

    public T SelectedValue { get; private set; } = default;

    public T DefaultValue { get; set; } = default;

    public List<T> Values { get; set; } = new();
}
