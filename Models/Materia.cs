using System;
namespace Eval.Models
{
    public class Materia
    {
        private int _IdMateria;
        public int IdMateria { get { return _IdMateria;} set { _IdMateria = value;}}

        private string _NombreMateria;
        public string NombreMateria { get { return _NombreMateria;} set { _NombreMateria = value;}}

        private int _Año;
        public int Año { get { return _Año;} set { _Año = value;}}
        
    }
}