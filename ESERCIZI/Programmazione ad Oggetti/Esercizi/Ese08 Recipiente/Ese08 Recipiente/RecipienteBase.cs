namespace Ese08_Recipiente
{
    internal class RecipienteBase
    {
        private int capacità;

        //virtual --> lo si mette sul padre cosi da poter fare l'override dal figlio

        public override string ToString()
        {
            return capacità.ToString();
        }
    }
}