using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Maui.Views;
using Syncfusion.Maui.DataGrid;
using SfDatagrid.Models;
using SfDatagrid.Services;
using SfDatagrid.Popups; // Make sure your MultiSelectPopup is in this namespace

namespace SfDatagrid;

public partial class SFDosagePage : ContentPage
{
    private List<Species> _previouslySelectedSpecies = new();
    public SFDosagePage()
    {
        InitializeComponent();
    }

    // 🚀 Handles row selection in the grid and updates the index in the ViewModel
    private void Datagrid_SelectionChanged(object sender, DataGridSelectionChangedEventArgs e)
    {
        if (e.AddedRows?.Count > 0)
        {
            var selectedRow = e.AddedRows[0] as Area;

            if (selectedRow != null && BindingContext is SFDosagePageViewModel vm)
            {
                int rowIndex = vm.Areas.IndexOf(selectedRow);
                if (rowIndex >= 0)
                    vm.IndexText = rowIndex.ToString();
            }
        }
    }

    // 🔽 Handle dropdown button click — shows MultiSelectPopup
    private async void OnSelectSpeciesClicked(object sender, EventArgs e)
    {
        var allSpecies = SpeciesDataService.GetSpecies();

        // Pass in previously selected ones
        var popup = new MultiSelectPopup(allSpecies, _previouslySelectedSpecies);
        var result = await this.ShowPopupAsync(popup);

        if (popup.SelectedSpecies?.Any() == true)
        {
            _previouslySelectedSpecies = popup.SelectedSpecies
                .Select(x => x.Species)
                .ToList();

            var selectedNames = _previouslySelectedSpecies.Select(x => x.CommonName);
            await DisplayAlert("Selected Species", string.Join(", ", selectedNames), "OK");

            // OPTIONAL: bind to ViewModel or update your state
        }
    }

    
}