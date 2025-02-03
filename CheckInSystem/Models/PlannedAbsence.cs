using System.ComponentModel;
using System.Runtime.CompilerServices;
using Dapper;
using System.Data.SqlClient;
using CheckInSystem.Database;

namespace CheckInSystem.Models;

public class PlannedAbsence : INotifyPropertyChanged
{
    public int ID { get; private set; }

    private DateTime _fromDate;
    public DateTime Fromdate
    {
        get => _fromDate; 
        set => SetProperty(ref _fromDate, value);
    }

    private DateTime _toDate;
    public DateTime Todate
    {
        get => _toDate;
        set => SetProperty(ref _toDate, value);
    }

    private string _note;
    public string Note
    {
        get => _note;
        set => SetProperty(ref _note, value);
    }

    public string Validate()
    {
        return "";
    }


    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    protected void SetProperty<T>(ref T variable, T value, [CallerMemberName] string? propertyName = null)
    {
        if (!EqualityComparer<T>.Default.Equals(variable, value))
        {
            variable = value;
            OnPropertyChanged(propertyName);
        }
    }
}
