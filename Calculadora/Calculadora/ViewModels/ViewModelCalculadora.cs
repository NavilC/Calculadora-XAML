using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Calculadora.models;

namespace Calculadora.ViewModels
{
    public class ViewModelCalculadora : INotifyPropertyChanged
    {
        int primerNumero;
        int segundoNumero;
        string proyeccion;

        public ViewModelCalculadora()
        {
            
            sumar = new Command(() =>
            {
                Calculadoras calculadora = new Calculadoras()
                {
                    primerNumero = this.primerNumero,
                    segundoNumero = this.segundoNumero,
                };
                Proyeccion = calculadora.sumar().ToString();
            });

            Resta = new Command(() =>
            {
                Calculadoras calculadora = new Calculadoras()
                {
                    primerNumero = this.primerNumero,
                    segundoNumero = this.segundoNumero,
                };
                Proyeccion = calculadora.Resta().ToString();
            });

            division = new Command(() =>
            {
                Calculadoras calculadora = new Calculadoras()
                {
                    primerNumero = this.primerNumero,
                    segundoNumero = this.segundoNumero,
                };
                Proyeccion = calculadora.division().ToString();
            });

            multiplicar = new Command(() =>
            {
                Calculadoras calculadora = new Calculadoras()
                {
                    primerNumero = this.primerNumero,
                    segundoNumero = this.segundoNumero,
                };
                Proyeccion = calculadora.multiplicar().ToString();
            });
        }

        public string Proyeccion
        {
            get => proyeccion;
            set
            {
                proyeccion = value;
                var argsEvent = new PropertyChangedEventArgs(nameof(Proyeccion));
                PropertyChanged?.Invoke(this, argsEvent);
            }
        }
        public int PrimerNumero
        {
            get => primerNumero;
            set
            {
                primerNumero = value;
                var argsEvent = new PropertyChangedEventArgs(nameof(PrimerNumero));
                PropertyChanged?.Invoke(this, argsEvent);
            }
        }
        public int SegundoNumero
        {
            get => segundoNumero;
            set
            {
                segundoNumero = value;
                var argsEvent = new PropertyChangedEventArgs(nameof(SegundoNumero));
                PropertyChanged?.Invoke(this, argsEvent);
            }
        }

        public Command sumar { get; }
        public Command Resta { get; }
        public Command division { get; }
        public Command multiplicar { get; }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
   

