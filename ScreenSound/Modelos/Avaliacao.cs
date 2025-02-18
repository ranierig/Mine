namespace ScreenSound.Modelos {
    internal class Avaliacao {
        public int Nota { get;  }

        public Avaliacao(int nota) {
            this.Nota = nota;
        }

        public static Avaliacao Parse (String notaTexto) {
            int nota = int.Parse(notaTexto);
            return new Avaliacao(nota);
        }

    }
}