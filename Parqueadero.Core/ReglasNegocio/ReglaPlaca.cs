namespace Parqueadero.Core.ReglasNegocio
{
    class ReglaPlaca
    {
        #region constante
        private const string Letra = "a";
        #endregion

        public bool EmpiezaPorA(string placa)
        {
            return placa.ToLower().StartsWith(Letra);
        }
    }
}
