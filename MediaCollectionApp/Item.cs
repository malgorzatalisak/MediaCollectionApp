using System;
using System.ComponentModel;

public enum MediaType
{
    VHS,
    DVD,
    BluRay,
    Kasete,
    CD,
    Pendrive
}

public class Item : INotifyPropertyChanged
{
    private string _title;
    public string Title
    {
        get { return _title; }
        set
        {
            _title = value;
            OnPropertyChanged(nameof(Title));
        }
    }

    private string _directorOrArtist;
    public string DirectorOrArtist
    {
        get { return _directorOrArtist; }
        set
        {
            _directorOrArtist = value;
            OnPropertyChanged(nameof(DirectorOrArtist));
        }
    }

    private string _publisherOrStudio;
    public string PublisherOrStudio
    {
        get { return _publisherOrStudio; }
        set
        {
            _publisherOrStudio = value;
            OnPropertyChanged(nameof(PublisherOrStudio));
        }
    }

    private MediaType _mediaType;
    public MediaType MediaType
    {
        get { return _mediaType; }
        set
        {
            _mediaType = value;
            OnPropertyChanged(nameof(MediaType));
        }
    }

    private TimeSpan _duration;
    public TimeSpan Duration
    {
        get { return _duration; }
        set
        {
            _duration = value;
            OnPropertyChanged(nameof(Duration));
        }
    }

    private DateTime _releaseDate;
    public DateTime ReleaseDate
    {
        get { return _releaseDate; }
        set
        {
            _releaseDate = value;
            OnPropertyChanged(nameof(ReleaseDate));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
