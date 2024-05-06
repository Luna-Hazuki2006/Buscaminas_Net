namespace Buscaminas.Components.Pages.Nuevo
{
    public partial class Juego {
        private int Bombas = 0;
        private int Filas = 8;
        private int Columnas = 8;
        private int BombasTotales = 10;
        private string Actual = "";

        private enum Opciones
        {
            Fácil, 
            Media, 
            Difícil
        }

        public void Reiniciar()
        {
            switch (Actual)
            {
                case "Fácil":
                    Columnas = 8;
                    Filas = 8;
                    BombasTotales = 10;
                    break;
                case "Media":
                    Columnas = 16;
                    Filas = 16;
                    BombasTotales = 44;
                    break;
                case "Difícil":
                    Columnas = 30;
                    Filas = 16;
                    BombasTotales = 99;
                    break;
                default:
                    Columnas = 8;
                    Filas = 8;
                    BombasTotales = 1000000;
                    break;
            }
        }

        public int randomFila()
        {
            var random = new Random();
            return random.Next(1, Filas + 1);
        }

        public int randomColumna()
        {
            var random = new Random();
            return random.Next(1, Columnas + 1);
        }

    }
}
