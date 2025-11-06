using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforo.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly Color _colorEncendidoRojo=Colors.Red;
        private readonly Color _colorEncendidoAmarillo=Colors.Yellow;
        private readonly Color _colorEncendidoVerde=Colors.Green;
        private readonly Color _colorDefecto = Colors.Black;

        [ObservableProperty]
        private Color _colorSemaforo1;
        [ObservableProperty]
        private Color _colorSemaforo2;
        [ObservableProperty]
        private Color _colorSemaforo3;


        #region CONSTRUCTOR 
        public MainViewModel()
        {
            _colorSemaforo1 = _colorDefecto;
            _colorSemaforo2 = _colorDefecto;
            _colorSemaforo3 = _colorDefecto;
        }
        #endregion

        #region COMANDS
        [RelayCommand]
        private void encenderSemaforo1()
        {
            if (ColorSemaforo1 == _colorDefecto)
            {
                ColorSemaforo1 = _colorEncendidoRojo;
                ColorSemaforo2 = _colorDefecto;
                ColorSemaforo3 = _colorDefecto;
            }
            /*
            else
            {
                ColorSemaforo1 = _colorDefecto;
            }   
            */
        }
        [RelayCommand]
        private void encenderSemaforo2()
        {
            if (ColorSemaforo2 == _colorDefecto)
            {
                ColorSemaforo2 = _colorEncendidoAmarillo;
                ColorSemaforo1 = _colorDefecto;
                ColorSemaforo3 = _colorDefecto;
            }
            /*
            else
            {
                ColorSemaforo2 = _colorDefecto;
            }
            */
        }
        [RelayCommand]
        private void encenderSemaforo3()
        {
            if (ColorSemaforo3 == _colorDefecto)
            {
                ColorSemaforo3 = _colorEncendidoVerde;
                ColorSemaforo2 = _colorDefecto;
                ColorSemaforo1 = _colorDefecto;
            }
            /*
            else
            {
                ColorSemaforo3 = _colorDefecto;
            }
            */
        }
        #endregion
    }
}
