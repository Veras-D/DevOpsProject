using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TarotApp.Models;
using TarotApp.Services;
using Avalonia.Media.Imaging;

namespace TarotApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly TarotService _tarotService;
        private TarotCard _currentCard;
        private Bitmap _currentCardImage;
        private string _cardName;
        private bool _isInitialState = true;

        public TarotCard CurrentCard
        {
            get => _currentCard;
            private set
            {
                if (_currentCard != value)
                {
                    _currentCard = value;
                    OnPropertyChanged();
                }
            }
        }

        public Bitmap CurrentCardImage
        {
            get => _currentCardImage;
            private set
            {
                if (_currentCardImage != value)
                {
                    _currentCardImage = value;
                    OnPropertyChanged();
                }
            }
        }

        public string CardName
        {
            get => _cardName;
            private set
            {
                if (_cardName != value)
                {
                    _cardName = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool ShowCardName => !_isInitialState;

        // Comandos para os botões
        public ICommand DrawCardCommand { get; }
        public ICommand ResetCommand { get; }

        public MainViewModel()
        {
            _tarotService = new TarotService();
            
            DrawCardCommand = new RelayCommand(DrawCard);
            ResetCommand = new RelayCommand(Reset);
            
            ShowBackCard();
        }

        private void ShowBackCard()
        {
            CurrentCard = _tarotService.GetBackCard();
            CurrentCardImage = CurrentCard.LoadImage();
            CardName = "";
            _isInitialState = true;
            OnPropertyChanged(nameof(ShowCardName));
        }

        public void DrawCard()
        {
            CurrentCard = _tarotService.DrawRandomCard();
            CurrentCardImage = CurrentCard.LoadImage();
            CardName = $"{CurrentCard.Id} - {CurrentCard.Name}";
            _isInitialState = false;
            OnPropertyChanged(nameof(ShowCardName));
        }

        public void Reset()
        {
            ShowBackCard();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute?.Invoke() ?? true;

        public void Execute(object parameter) => _execute();

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }
    }
}

