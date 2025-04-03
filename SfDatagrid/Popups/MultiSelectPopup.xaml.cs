using CommunityToolkit.Maui.Views;
using SfDatagrid.Models;
using System.Collections.Generic;
using System.Linq;

namespace SfDatagrid.Popups;

public partial class MultiSelectPopup : Popup
{
    public List<SelectableSpecies> SelectedSpecies { get; private set; } = new();
    private List<SelectableSpecies> _wrappedSpecies = new();

    public MultiSelectPopup(List<Species> allSpecies, List<Species>? previouslySelected = null)
    {
        InitializeComponent();

        _wrappedSpecies = allSpecies
            .Select(s => new SelectableSpecies
            {
                Species = s,
                IsSelected = previouslySelected?.Any(sel => sel.EPPOCode == s.EPPOCode) == true
            })
            .ToList();

        SpeciesList.ItemsSource = _wrappedSpecies;
    }
    

    private void OnDoneClicked(object sender, EventArgs e)
    {
        SelectedSpecies = _wrappedSpecies
            .Where(x => x.IsSelected)
            .ToList();

        Close();
    }

    // 🧠 Handles check/uncheck events and updates the status label
    private void OnCheckChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox && checkBox.BindingContext is SelectableSpecies item)
        {
            // Get all items that are selected
            var selected = ((List<SelectableSpecies>)SpeciesList.ItemsSource)
                .Where(x => x.IsSelected)
                .Select(x => $"• {x.CommonName}");

            if (selected.Any())
            {
                SelectedStatusLabel.Text = $"You checked ✅:\n{string.Join("\n", selected)}";
            }
            else
            {
                SelectedStatusLabel.Text = string.Empty;
            }
        }
    }

}

public class SelectableSpecies
{
    public Species Species { get; set; }
    public bool IsSelected { get; set; } = false;
    public string CommonName => Species?.CommonName;
}