using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SfDatagrid;

// Area model stays the same
public class Area
{
    public string AreaName { get; set; }
    
    public string Temperature { get; set; }
    
    public string EstimatedHalfLossTime { get; set; }
    
    public string ExposureTime { get; set; }
    public string AreaVolume { get; set; }
   
    public string UserDefinedCT { get; set; }
    
 public string TargetCT { get; set; }
    
    public string FumigantRequired { get; set; }
    public string InitialConcentration { get; set; }

    
}


// ViewModel now uses ObservableObject to support binding
public partial class SFDosagePageViewModel : ObservableObject
{
    private int _areaCounter = 1;
    
    // Collection of Area rows
    [ObservableProperty]
    private ObservableCollection<Area> areas = new();

    // User-entered index in Entry field (as string for easier binding)
    [ObservableProperty]
    private string indexText;
    

    public SFDosagePageViewModel()
    {
        Areas = new ObservableCollection<Area>
        {
            new Area
            {
                AreaName = "Test",
                Temperature = "77 'F",
                EstimatedHalfLossTime = "12.00 h",
                ExposureTime = "24.00 h",
                AreaVolume = "283.293 ft",
                UserDefinedCT = "0.00",
                TargetCT = "1,210.10 oz",
                FumigantRequired = "135.07 lb",
                InitialConcentration = "92.99 oz/ft",
            }
        };
    }

    // RelayCommand for adding a new row
    [RelayCommand]
    private void AddRow()
    {
        var area = new Area
        {
            AreaName = "Test",
            Temperature = "70 'F",
            EstimatedHalfLossTime = "12.00 h",
            ExposureTime = "24.00 h",
            AreaVolume = "100 ft",
            UserDefinedCT = "0.00",
            TargetCT = "0.00 oz",
            FumigantRequired = "135 lb",
            InitialConcentration = "50.00 oz/ft",
        };

        if (int.TryParse(IndexText, out int index) && index >= 0 && index <= Areas.Count)
        {
            Areas.Insert(index, area);
        }
        else
        {
            Areas.Add(area); // fallback to append
        }

        IndexText = string.Empty; // clear entry field
    }

    // RelayCommand for deleting a row
    [RelayCommand]
    private async Task DeleteRowAsync()
    {
        // Parse the index first
        if (int.TryParse(IndexText, out int index) &&
            index >= 0 && index < Areas.Count)
        {
            var area = Areas[index];

            // Ask the user if they really want to delete it
            bool confirm = await Shell.Current.DisplayAlert(
                "Confirm Delete",
                $"Delete \"{area.AreaName}\"?",
                "Delete",
                "Cancel");

            if (confirm)
            {
                Areas.RemoveAt(index);
            }
        }

        IndexText = string.Empty; // always clear the entry box
    }

}
